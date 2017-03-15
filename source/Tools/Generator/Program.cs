﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Pihrtsoft.Records;
using Pihrtsoft.Snippets.CodeGeneration.Markdown;

namespace Pihrtsoft.Snippets.CodeGeneration
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            var settings = new GeneralSettings() { SolutionDirectoryPath = @"..\..\..\..\.." };

            SnippetDirectory[] snippetDirectories = SnippetDirectory.LoadFromFile(@"..\..\SnippetDirectories.xml").ToArray();

            CharacterSequence[] characterSequences = CharacterSequence.LoadFromFile(@"..\..\CharacterSequences.xml", settings.DirectoryNamePrefix).ToArray();

            GenerateSnippets(snippetDirectories);
            SnippetGenerator.GenerateHtmlSnippets(snippetDirectories);
            SnippetGenerator.GenerateXamlSnippets(snippetDirectories);
            SnippetGenerator.GenerateXmlSnippets(snippetDirectories);

            SnippetDirectory[] releaseDirectories = snippetDirectories
                .Where(f => f.HasTag(KnownTags.Release) && !f.HasTag(KnownTags.Dev))
                .ToArray();

            MarkdownGenerator.WriteSolutionReadMe(releaseDirectories, settings);

            MarkdownGenerator.WriteProjectMarkdownFiles(releaseDirectories, Path.GetFullPath(settings.ProjectPath));

            MarkdownGenerator.WriteDirectoryMarkdownFiles(
                snippetDirectories
                    .Where(f => f.HasAnyTag(KnownTags.Release, KnownTags.Dev) && !f.HasAnyTag(KnownTags.AutoGenerationSource, KnownTags.AutoGenerationDestination))
                    .ToArray(),
                characterSequences);

            SnippetPackageGenerator.GenerateVisualStudioPackageFiles(
                releaseDirectories: releaseDirectories,
                characterSequences: characterSequences,
                releases: Release.LoadFromDocument(@"..\..\ChangeLog.xml").ToArray(),
                settings: settings);

            settings.ExtensionProjectName += ".Dev";

            SnippetPackageGenerator.GenerateVisualStudioPackageFiles(
                releaseDirectories: snippetDirectories
                    .Where(f => f.HasTags(KnownTags.Release, KnownTags.Dev))
                    .ToArray(),
                characterSequences: null,
                releases: null,
                settings: settings);

            SnippetChecker.CheckSnippets(snippetDirectories);

            Console.WriteLine("*** END ***");
            Console.ReadKey();
        }

        private static void GenerateSnippets(SnippetDirectory[] snippetDirectories)
        {
            IEnumerable<Record> records = Document.ReadRecords(@"..\..\Records.xml")
                .Where(f => !f.HasTag(KnownTags.Disabled));

            LanguageDefinition[] languages = records
                .Where(f => f.ContainsProperty(KnownTags.Language))
                .ToLanguageDefinitions()
                .ToArray();

            foreach (LanguageDefinition language in languages)
            {
                var settings = new SnippetGeneratorSettings(language);

                foreach (TypeDefinition typeInfo in records
                    .Where(f => f.HasTag(KnownTags.Collection))
                    .ToTypeDefinitions())
                {
                    settings.Types.Add(typeInfo);
                }

                language.GenerateSnippets(snippetDirectories, settings);
            }
        }
    }
}
