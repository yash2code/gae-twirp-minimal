// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: backend/rpc/haberdasher/service.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Pj.Protobuf.Haberdasher {

  /// <summary>Holder for reflection information generated from backend/rpc/haberdasher/service.proto</summary>
  public static partial class ServiceReflection {

    #region Descriptor
    /// <summary>File descriptor for backend/rpc/haberdasher/service.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ServiceReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiViYWNrZW5kL3JwYy9oYWJlcmRhc2hlci9zZXJ2aWNlLnByb3RvEhl0d2ly",
            "cC5leGFtcGxlLmhhYmVyZGFzaGVyIhYKBFNpemUSDgoGaW5jaGVzGAEgASgF",
            "Ij4KA0hhdBIKCgJpZBgBIAEoCRIOCgZpbmNoZXMYAiABKAUSDQoFY29sb3IY",
            "AyABKAkSDAoEbmFtZRgEIAEoCTJZCgtIYWJlcmRhc2hlchJKCgdNYWtlSGF0",
            "Eh8udHdpcnAuZXhhbXBsZS5oYWJlcmRhc2hlci5TaXplGh4udHdpcnAuZXhh",
            "bXBsZS5oYWJlcmRhc2hlci5IYXRCJ1oLaGFiZXJkYXNoZXKqAhdQai5Qcm90",
            "b2J1Zi5IYWJlcmRhc2hlcmIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Pj.Protobuf.Haberdasher.Size), global::Pj.Protobuf.Haberdasher.Size.Parser, new[]{ "Inches" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Pj.Protobuf.Haberdasher.Hat), global::Pj.Protobuf.Haberdasher.Hat.Parser, new[]{ "Id", "Inches", "Color", "Name" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Size of a Hat, in inches.
  /// </summary>
  public sealed partial class Size : pb::IMessage<Size> {
    private static readonly pb::MessageParser<Size> _parser = new pb::MessageParser<Size>(() => new Size());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<Size> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Pj.Protobuf.Haberdasher.ServiceReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Size() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Size(Size other) : this() {
      inches_ = other.inches_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Size Clone() {
      return new Size(this);
    }

    /// <summary>Field number for the "inches" field.</summary>
    public const int InchesFieldNumber = 1;
    private int inches_;
    /// <summary>
    /// must be > 0
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int Inches {
      get { return inches_; }
      set {
        inches_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as Size);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(Size other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Inches != other.Inches) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Inches != 0) hash ^= Inches.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (Inches != 0) {
        output.WriteRawTag(8);
        output.WriteInt32(Inches);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Inches != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Inches);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(Size other) {
      if (other == null) {
        return;
      }
      if (other.Inches != 0) {
        Inches = other.Inches;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 8: {
            Inches = input.ReadInt32();
            break;
          }
        }
      }
    }

  }

  /// <summary>
  /// A Hat is a piece of headwear made by a Haberdasher.
  /// </summary>
  public sealed partial class Hat : pb::IMessage<Hat> {
    private static readonly pb::MessageParser<Hat> _parser = new pb::MessageParser<Hat>(() => new Hat());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<Hat> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Pj.Protobuf.Haberdasher.ServiceReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Hat() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Hat(Hat other) : this() {
      id_ = other.id_;
      inches_ = other.inches_;
      color_ = other.color_;
      name_ = other.name_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Hat Clone() {
      return new Hat(this);
    }

    /// <summary>Field number for the "id" field.</summary>
    public const int IdFieldNumber = 1;
    private string id_ = "";
    /// <summary>
    /// [json_name="hat_id"];
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Id {
      get { return id_; }
      set {
        id_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "inches" field.</summary>
    public const int InchesFieldNumber = 2;
    private int inches_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int Inches {
      get { return inches_; }
      set {
        inches_ = value;
      }
    }

    /// <summary>Field number for the "color" field.</summary>
    public const int ColorFieldNumber = 3;
    private string color_ = "";
    /// <summary>
    /// anything but "invisible"
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Color {
      get { return color_; }
      set {
        color_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "name" field.</summary>
    public const int NameFieldNumber = 4;
    private string name_ = "";
    /// <summary>
    /// [(gogoproto.moretags) = "datastore:\",noindex\""]; // i.e. "bowler"
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Name {
      get { return name_; }
      set {
        name_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as Hat);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(Hat other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Id != other.Id) return false;
      if (Inches != other.Inches) return false;
      if (Color != other.Color) return false;
      if (Name != other.Name) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Id.Length != 0) hash ^= Id.GetHashCode();
      if (Inches != 0) hash ^= Inches.GetHashCode();
      if (Color.Length != 0) hash ^= Color.GetHashCode();
      if (Name.Length != 0) hash ^= Name.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (Id.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Id);
      }
      if (Inches != 0) {
        output.WriteRawTag(16);
        output.WriteInt32(Inches);
      }
      if (Color.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(Color);
      }
      if (Name.Length != 0) {
        output.WriteRawTag(34);
        output.WriteString(Name);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Id.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Id);
      }
      if (Inches != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Inches);
      }
      if (Color.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Color);
      }
      if (Name.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Name);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(Hat other) {
      if (other == null) {
        return;
      }
      if (other.Id.Length != 0) {
        Id = other.Id;
      }
      if (other.Inches != 0) {
        Inches = other.Inches;
      }
      if (other.Color.Length != 0) {
        Color = other.Color;
      }
      if (other.Name.Length != 0) {
        Name = other.Name;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            Id = input.ReadString();
            break;
          }
          case 16: {
            Inches = input.ReadInt32();
            break;
          }
          case 26: {
            Color = input.ReadString();
            break;
          }
          case 34: {
            Name = input.ReadString();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
