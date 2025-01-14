using System.Collections.Immutable;
using HotChocolate.Fusion.Events;
using HotChocolate.Fusion.PreMergeValidation.Info;
using HotChocolate.Language;
using HotChocolate.Skimmed;

namespace HotChocolate.Fusion.PreMergeValidation;

internal record DirectiveArgumentEvent(
    InputFieldDefinition Argument,
    DirectiveDefinition Directive,
    SchemaDefinition Schema) : IEvent;

internal record DirectiveEvent(
    DirectiveDefinition Directive,
    SchemaDefinition Schema) : IEvent;

internal record EnumTypeEvent(
    EnumTypeDefinition Type,
    SchemaDefinition Schema) : IEvent;

internal record EnumTypeGroupEvent(
    string TypeName,
    ImmutableArray<EnumTypeInfo> TypeGroup) : IEvent;

internal record FieldArgumentEvent(
    InputFieldDefinition Argument,
    OutputFieldDefinition Field,
    INamedTypeDefinition Type,
    SchemaDefinition Schema) : IEvent;

internal record FieldArgumentGroupEvent(
    string ArgumentName,
    ImmutableArray<FieldArgumentInfo> ArgumentGroup,
    string FieldName,
    string TypeName) : IEvent;

internal record InputFieldGroupEvent(
    string FieldName,
    ImmutableArray<InputFieldInfo> FieldGroup,
    string TypeName) : IEvent;

internal record InputTypeGroupEvent(
    string InputTypeName,
    ImmutableArray<InputTypeInfo> InputTypeGroup) : IEvent;

internal record KeyFieldEvent(
    ComplexTypeDefinition EntityType,
    Directive KeyDirective,
    OutputFieldDefinition Field,
    ComplexTypeDefinition Type,
    SchemaDefinition Schema) : IEvent;

internal record KeyFieldNodeEvent(
    ComplexTypeDefinition EntityType,
    Directive KeyDirective,
    FieldNode FieldNode,
    ImmutableArray<string> FieldNamePath,
    SchemaDefinition Schema) : IEvent;

internal record KeyFieldsInvalidReferenceEvent(
    ComplexTypeDefinition EntityType,
    Directive KeyDirective,
    FieldNode FieldNode,
    ComplexTypeDefinition Type,
    SchemaDefinition Schema) : IEvent;

internal record KeyFieldsInvalidSyntaxEvent(
    ComplexTypeDefinition EntityType,
    Directive KeyDirective,
    SchemaDefinition Schema) : IEvent;

internal record KeyFieldsInvalidTypeEvent(
    Directive KeyDirective,
    ComplexTypeDefinition EntityType,
    SchemaDefinition Schema) : IEvent;

internal record OutputFieldEvent(
    OutputFieldDefinition Field,
    INamedTypeDefinition Type,
    SchemaDefinition Schema) : IEvent;

internal record OutputFieldGroupEvent(
    string FieldName,
    ImmutableArray<OutputFieldInfo> FieldGroup,
    string TypeName) : IEvent;

internal record ProvidesFieldEvent(
    OutputFieldDefinition ProvidedField,
    ComplexTypeDefinition ProvidedType,
    Directive ProvidesDirective,
    OutputFieldDefinition Field,
    ComplexTypeDefinition Type,
    SchemaDefinition Schema) : IEvent;

internal record ProvidesFieldNodeEvent(
    FieldNode FieldNode,
    ImmutableArray<string> FieldNamePath,
    Directive ProvidesDirective,
    OutputFieldDefinition Field,
    ComplexTypeDefinition Type,
    SchemaDefinition Schema) : IEvent;

internal record ProvidesFieldsInvalidSyntaxEvent(
    Directive ProvidesDirective,
    OutputFieldDefinition Field,
    ComplexTypeDefinition Type,
    SchemaDefinition Schema) : IEvent;

internal record ProvidesFieldsInvalidTypeEvent(
    Directive ProvidesDirective,
    OutputFieldDefinition Field,
    ComplexTypeDefinition Type,
    SchemaDefinition Schema) : IEvent;

internal record RequireFieldNodeEvent(
    FieldNode FieldNode,
    ImmutableArray<string> FieldNamePath,
    Directive RequireDirective,
    InputFieldDefinition Argument,
    OutputFieldDefinition Field,
    ComplexTypeDefinition Type,
    SchemaDefinition Schema) : IEvent;

internal record RequireFieldsInvalidSyntaxEvent(
    Directive RequireDirective,
    InputFieldDefinition Argument,
    OutputFieldDefinition Field,
    ComplexTypeDefinition Type,
    SchemaDefinition Schema) : IEvent;

internal record SchemaEvent(SchemaDefinition Schema) : IEvent;

internal record TypeEvent(
    INamedTypeDefinition Type,
    SchemaDefinition Schema) : IEvent;

internal record TypeGroupEvent(
    string TypeName,
    ImmutableArray<TypeInfo> TypeGroup) : IEvent;
