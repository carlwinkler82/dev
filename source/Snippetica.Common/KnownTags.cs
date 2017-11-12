﻿// Copyright (c) Josef Pihrt. All rights reserved. Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

namespace Snippetica
{
    public static class KnownTags
    {
        public const string VisualStudio = nameof(VisualStudio);
        public const string Default = nameof(Default);
        public const string AccessModifier = nameof(AccessModifier);
        public const string Disabled = nameof(Disabled);
        public const string Collection = nameof(Collection);
        public const string Language = nameof(Language);
        public const string Immutable = nameof(Immutable);
        public const string Dictionary = nameof(Dictionary);
        public const string ArgumentList = nameof(ArgumentList);
        public const string Interface = nameof(Interface);
        public const string TryParse = nameof(TryParse);
        public const string Initializer = nameof(Initializer);
        public const string Array = nameof(Array);
        public const string AutoGenerated = nameof(AutoGenerated);
        public const string ShortcutSuffix = nameof(ShortcutSuffix);
        public const string AlternativeShortcut = nameof(AlternativeShortcut);
        public const string ObsoleteShortcut = nameof(ObsoleteShortcut);
        public const string Environment = nameof(Environment);

        public const string NonUniqueShortcut = nameof(NonUniqueShortcut);
        public const string NonUniqueTitle = nameof(NonUniqueTitle);
        public const string ExcludeFromReadme = nameof(ExcludeFromReadme);
        public const string TitleStartsWithShortcut = nameof(TitleStartsWithShortcut);
        public const string TitleEndsWithUnderscore = nameof(TitleEndsWithUnderscore);
        public const string ExcludeFromVisualStudio = nameof(ExcludeFromVisualStudio);
        public const string ExcludeFromVisualStudioCode = nameof(ExcludeFromVisualStudioCode);
        public const string NoQuickReference = nameof(NoQuickReference);
        public const string ExcludeFromSnippetBrowser = nameof(ExcludeFromSnippetBrowser);
        public const string GenerateXmlSnippets = "GenerateXmlSnippets";

        public const string MetaPrefix = "Meta-";
        private const string GeneratePrefix = "Generate";

        public const string GenerateAccessModifier = GeneratePrefix + "AccessModifier";
        public const string GeneratePublicModifier = GeneratePrefix + "PublicModifier";
        public const string GenerateInternalModifier = GeneratePrefix + "InternalModifier";
        public const string GeneratePrivateModifier = GeneratePrefix + "PrivateModifier";

        public const string GenerateStaticModifier = GeneratePrefix + "StaticModifier";
        public const string GenerateVirtualModifier = GeneratePrefix + "VirtualModifier";
        public const string GenerateInitializer = GeneratePrefix + "Initializer";
        public const string GenerateParameters = GeneratePrefix + "Parameters";
        public const string GenerateArguments = GeneratePrefix + "Arguments";
        public const string GenerateXamlProperty = GeneratePrefix + "XamlProperty";
        public const string GenerateUnchanged = GeneratePrefix + "Unchanged";
        public const string GenerateCollection = GeneratePrefix + "Collection";
        public const string GenerateImmutableCollection = GeneratePrefix + "ImmutableCollection";
        public const string GenerateAlternativeShortcut = GeneratePrefix + "AlternativeShortcut";

        public const string GenerateType = GeneratePrefix + "Type";
        public const string GenerateVoidType = GeneratePrefix + "VoidType";
        public const string GenerateBooleanType = GeneratePrefix + "BooleanType";
        public const string GenerateDateTimeType = GeneratePrefix + "DateTimeType";
        public const string GenerateDoubleType = GeneratePrefix + "DoubleType";
        public const string GenerateDecimalType = GeneratePrefix + "DecimalType";
        public const string GenerateInt32Type = GeneratePrefix + "Int32Type";
        public const string GenerateInt64Type = GeneratePrefix + "Int64Type";
        public const string GenerateObjectType = GeneratePrefix + "ObjectType";
        public const string GenerateStringType = GeneratePrefix + "StringType";
        public const string GenerateSingleType = GeneratePrefix + "SingleType";

        public static string GenerateTypeTag(string typeName)
        {
            return GeneratePrefix + typeName + "Type";
        }

        public static string GenerateModifierTag(string modifierName)
        {
            return GeneratePrefix + modifierName + "Modifier";
        }
    }
}
