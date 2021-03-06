// Generated by ProtoGen, Version=2.4.1.521, Culture=neutral, PublicKeyToken=17b3b1f090c3ea48.  DO NOT EDIT!
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.ProtocolBuffers;
using pbc = global::Google.ProtocolBuffers.Collections;
using pbd = global::Google.ProtocolBuffers.Descriptors;
using scg = global::System.Collections.Generic;
namespace FrameWork {
  
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public static partial class AuthSessionTokenReqProto {
  
    #region Extension registration
    public static void RegisterAllExtensions(pb::ExtensionRegistry registry) {
    }
    #endregion
    #region Static variables
    internal static pbd::MessageDescriptor internal__static_login_proto_AuthSessionTokenReq__Descriptor;
    internal static pb::FieldAccess.FieldAccessorTable<global::FrameWork.AuthSessionTokenReq, global::FrameWork.AuthSessionTokenReq.Builder> internal__static_login_proto_AuthSessionTokenReq__FieldAccessorTable;
    #endregion
    #region Descriptor
    public static pbd::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbd::FileDescriptor descriptor;
    
    static AuthSessionTokenReqProto() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          "Ch13YXIvQXV0aFNlc3Npb25Ub2tlblJlcS5wcm90bxILbG9naW4ucHJvdG8a" + 
          "JGdvb2dsZS9wcm90b2J1Zi9jc2hhcnBfb3B0aW9ucy5wcm90byIsChNBdXRo" + 
          "U2Vzc2lvblRva2VuUmVxEhUKDXNlc3Npb25fdG9rZW4YASACKAxCKMI+JQoJ" + 
          "RnJhbWVXb3JrEhhBdXRoU2Vzc2lvblRva2VuUmVxUHJvdG8=");
      pbd::FileDescriptor.InternalDescriptorAssigner assigner = delegate(pbd::FileDescriptor root) {
        descriptor = root;
        internal__static_login_proto_AuthSessionTokenReq__Descriptor = Descriptor.MessageTypes[0];
        internal__static_login_proto_AuthSessionTokenReq__FieldAccessorTable = 
            new pb::FieldAccess.FieldAccessorTable<global::FrameWork.AuthSessionTokenReq, global::FrameWork.AuthSessionTokenReq.Builder>(internal__static_login_proto_AuthSessionTokenReq__Descriptor,
                new string[] { "SessionToken", });
        pb::ExtensionRegistry registry = pb::ExtensionRegistry.CreateInstance();
        RegisterAllExtensions(registry);
        global::Google.ProtocolBuffers.DescriptorProtos.CSharpOptions.RegisterAllExtensions(registry);
        return registry;
      };
      pbd::FileDescriptor.InternalBuildGeneratedFileFrom(descriptorData,
          new pbd::FileDescriptor[] {
          global::Google.ProtocolBuffers.DescriptorProtos.CSharpOptions.Descriptor, 
          }, assigner);
    }
    #endregion
    
  }
  #region Messages
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public sealed partial class AuthSessionTokenReq : pb::GeneratedMessage<AuthSessionTokenReq, AuthSessionTokenReq.Builder> {
    private AuthSessionTokenReq() { }
    private static readonly AuthSessionTokenReq defaultInstance = new AuthSessionTokenReq().MakeReadOnly();
    private static readonly string[] _authSessionTokenReqFieldNames = new string[] { "session_token" };
    private static readonly uint[] _authSessionTokenReqFieldTags = new uint[] { 10 };
    public static AuthSessionTokenReq DefaultInstance {
      get { return defaultInstance; }
    }
    
    public override AuthSessionTokenReq DefaultInstanceForType {
      get { return DefaultInstance; }
    }
    
    protected override AuthSessionTokenReq ThisMessage {
      get { return this; }
    }
    
    public static pbd::MessageDescriptor Descriptor {
      get { return global::FrameWork.AuthSessionTokenReqProto.internal__static_login_proto_AuthSessionTokenReq__Descriptor; }
    }
    
    protected override pb::FieldAccess.FieldAccessorTable<AuthSessionTokenReq, AuthSessionTokenReq.Builder> InternalFieldAccessors {
      get { return global::FrameWork.AuthSessionTokenReqProto.internal__static_login_proto_AuthSessionTokenReq__FieldAccessorTable; }
    }
    
    public const int SessionTokenFieldNumber = 1;
    private bool hasSessionToken;
    private pb::ByteString sessionToken_ = pb::ByteString.Empty;
    public bool HasSessionToken {
      get { return hasSessionToken; }
    }
    public pb::ByteString SessionToken {
      get { return sessionToken_; }
    }
    
    public override bool IsInitialized {
      get {
        if (!hasSessionToken) return false;
        return true;
      }
    }
    
    public override void WriteTo(pb::ICodedOutputStream output) {
      int size = SerializedSize;
      string[] field_names = _authSessionTokenReqFieldNames;
      if (hasSessionToken) {
        output.WriteBytes(1, field_names[0], SessionToken);
      }
      UnknownFields.WriteTo(output);
    }
    
    private int memoizedSerializedSize = -1;
    public override int SerializedSize {
      get {
        int size = memoizedSerializedSize;
        if (size != -1) return size;
        
        size = 0;
        if (hasSessionToken) {
          size += pb::CodedOutputStream.ComputeBytesSize(1, SessionToken);
        }
        size += UnknownFields.SerializedSize;
        memoizedSerializedSize = size;
        return size;
      }
    }
    
    public static AuthSessionTokenReq ParseFrom(pb::ByteString data) {
      return ((Builder) CreateBuilder().MergeFrom(data)).BuildParsed();
    }
    public static AuthSessionTokenReq ParseFrom(pb::ByteString data, pb::ExtensionRegistry extensionRegistry) {
      return ((Builder) CreateBuilder().MergeFrom(data, extensionRegistry)).BuildParsed();
    }
    public static AuthSessionTokenReq ParseFrom(byte[] data) {
      return ((Builder) CreateBuilder().MergeFrom(data)).BuildParsed();
    }
    public static AuthSessionTokenReq ParseFrom(byte[] data, pb::ExtensionRegistry extensionRegistry) {
      return ((Builder) CreateBuilder().MergeFrom(data, extensionRegistry)).BuildParsed();
    }
    public static AuthSessionTokenReq ParseFrom(global::System.IO.Stream input) {
      return ((Builder) CreateBuilder().MergeFrom(input)).BuildParsed();
    }
    public static AuthSessionTokenReq ParseFrom(global::System.IO.Stream input, pb::ExtensionRegistry extensionRegistry) {
      return ((Builder) CreateBuilder().MergeFrom(input, extensionRegistry)).BuildParsed();
    }
    public static AuthSessionTokenReq ParseDelimitedFrom(global::System.IO.Stream input) {
      return CreateBuilder().MergeDelimitedFrom(input).BuildParsed();
    }
    public static AuthSessionTokenReq ParseDelimitedFrom(global::System.IO.Stream input, pb::ExtensionRegistry extensionRegistry) {
      return CreateBuilder().MergeDelimitedFrom(input, extensionRegistry).BuildParsed();
    }
    public static AuthSessionTokenReq ParseFrom(pb::ICodedInputStream input) {
      return ((Builder) CreateBuilder().MergeFrom(input)).BuildParsed();
    }
    public static AuthSessionTokenReq ParseFrom(pb::ICodedInputStream input, pb::ExtensionRegistry extensionRegistry) {
      return ((Builder) CreateBuilder().MergeFrom(input, extensionRegistry)).BuildParsed();
    }
    private AuthSessionTokenReq MakeReadOnly() {
      return this;
    }
    
    public static Builder CreateBuilder() { return new Builder(); }
    public override Builder ToBuilder() { return CreateBuilder(this); }
    public override Builder CreateBuilderForType() { return new Builder(); }
    public static Builder CreateBuilder(AuthSessionTokenReq prototype) {
      return new Builder(prototype);
    }
    
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public sealed partial class Builder : pb::GeneratedBuilder<AuthSessionTokenReq, Builder> {
      protected override Builder ThisBuilder {
        get { return this; }
      }
      public Builder() {
        result = DefaultInstance;
        resultIsReadOnly = true;
      }
      internal Builder(AuthSessionTokenReq cloneFrom) {
        result = cloneFrom;
        resultIsReadOnly = true;
      }
      
      private bool resultIsReadOnly;
      private AuthSessionTokenReq result;
      
      private AuthSessionTokenReq PrepareBuilder() {
        if (resultIsReadOnly) {
          AuthSessionTokenReq original = result;
          result = new AuthSessionTokenReq();
          resultIsReadOnly = false;
          MergeFrom(original);
        }
        return result;
      }
      
      public override bool IsInitialized {
        get { return result.IsInitialized; }
      }
      
      protected override AuthSessionTokenReq MessageBeingBuilt {
        get { return PrepareBuilder(); }
      }
      
      public override Builder Clear() {
        result = DefaultInstance;
        resultIsReadOnly = true;
        return this;
      }
      
      public override Builder Clone() {
        if (resultIsReadOnly) {
          return new Builder(result);
        } else {
          return new Builder().MergeFrom(result);
        }
      }
      
      public override pbd::MessageDescriptor DescriptorForType {
        get { return global::FrameWork.AuthSessionTokenReq.Descriptor; }
      }
      
      public override AuthSessionTokenReq DefaultInstanceForType {
        get { return global::FrameWork.AuthSessionTokenReq.DefaultInstance; }
      }
      
      public override AuthSessionTokenReq BuildPartial() {
        if (resultIsReadOnly) {
          return result;
        }
        resultIsReadOnly = true;
        return result.MakeReadOnly();
      }
      
      public override Builder MergeFrom(pb::IMessage other) {
        if (other is AuthSessionTokenReq) {
          return MergeFrom((AuthSessionTokenReq) other);
        } else {
          base.MergeFrom(other);
          return this;
        }
      }
      
      public override Builder MergeFrom(AuthSessionTokenReq other) {
        if (other == global::FrameWork.AuthSessionTokenReq.DefaultInstance) return this;
        PrepareBuilder();
        if (other.HasSessionToken) {
          SessionToken = other.SessionToken;
        }
        this.MergeUnknownFields(other.UnknownFields);
        return this;
      }
      
      public override Builder MergeFrom(pb::ICodedInputStream input) {
        return MergeFrom(input, pb::ExtensionRegistry.Empty);
      }
      
      public override Builder MergeFrom(pb::ICodedInputStream input, pb::ExtensionRegistry extensionRegistry) {
        PrepareBuilder();
        pb::UnknownFieldSet.Builder unknownFields = null;
        uint tag;
        string field_name;
        while (input.ReadTag(out tag, out field_name)) {
          if(tag == 0 && field_name != null) {
            int field_ordinal = global::System.Array.BinarySearch(_authSessionTokenReqFieldNames, field_name, global::System.StringComparer.Ordinal);
            if(field_ordinal >= 0)
              tag = _authSessionTokenReqFieldTags[field_ordinal];
            else {
              if (unknownFields == null) {
                unknownFields = pb::UnknownFieldSet.CreateBuilder(this.UnknownFields);
              }
              ParseUnknownField(input, unknownFields, extensionRegistry, tag, field_name);
              continue;
            }
          }
          switch (tag) {
            case 0: {
              throw pb::InvalidProtocolBufferException.InvalidTag();
            }
            default: {
              if (pb::WireFormat.IsEndGroupTag(tag)) {
                if (unknownFields != null) {
                  this.UnknownFields = unknownFields.Build();
                }
                return this;
              }
              if (unknownFields == null) {
                unknownFields = pb::UnknownFieldSet.CreateBuilder(this.UnknownFields);
              }
              ParseUnknownField(input, unknownFields, extensionRegistry, tag, field_name);
              break;
            }
            case 10: {
              result.hasSessionToken = input.ReadBytes(ref result.sessionToken_);
              break;
            }
          }
        }
        
        if (unknownFields != null) {
          this.UnknownFields = unknownFields.Build();
        }
        return this;
      }
      
      
      public bool HasSessionToken {
        get { return result.hasSessionToken; }
      }
      public pb::ByteString SessionToken {
        get { return result.SessionToken; }
        set { SetSessionToken(value); }
      }
      public Builder SetSessionToken(pb::ByteString value) {
        pb::ThrowHelper.ThrowIfNull(value, "value");
        PrepareBuilder();
        result.hasSessionToken = true;
        result.sessionToken_ = value;
        return this;
      }
      public Builder ClearSessionToken() {
        PrepareBuilder();
        result.hasSessionToken = false;
        result.sessionToken_ = pb::ByteString.Empty;
        return this;
      }
    }
    static AuthSessionTokenReq() {
      object.ReferenceEquals(global::FrameWork.AuthSessionTokenReqProto.Descriptor, null);
    }
  }
  
  #endregion
  
}

#endregion Designer generated code
