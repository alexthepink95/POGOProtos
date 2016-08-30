// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: POGOProtos/Inventory/InventoryUpgrade.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace POGOProtos.Inventory {

  /// <summary>Holder for reflection information generated from POGOProtos/Inventory/InventoryUpgrade.proto</summary>
  public static partial class InventoryUpgradeReflection {

    #region Descriptor
    /// <summary>File descriptor for POGOProtos/Inventory/InventoryUpgrade.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static InventoryUpgradeReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CitQT0dPUHJvdG9zL0ludmVudG9yeS9JbnZlbnRvcnlVcGdyYWRlLnByb3Rv",
            "EhRQT0dPUHJvdG9zLkludmVudG9yeRovUE9HT1Byb3Rvcy9JbnZlbnRvcnkv",
            "SW52ZW50b3J5VXBncmFkZVR5cGUucHJvdG8aJlBPR09Qcm90b3MvSW52ZW50",
            "b3J5L0l0ZW0vSXRlbUlkLnByb3RvIqQBChBJbnZlbnRvcnlVcGdyYWRlEjIK",
            "B2l0ZW1faWQYASABKA4yIS5QT0dPUHJvdG9zLkludmVudG9yeS5JdGVtLkl0",
            "ZW1JZBJACgx1cGdyYWRlX3R5cGUYAiABKA4yKi5QT0dPUHJvdG9zLkludmVu",
            "dG9yeS5JbnZlbnRvcnlVcGdyYWRlVHlwZRIaChJhZGRpdGlvbmFsX3N0b3Jh",
            "Z2UYAyABKAViBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::POGOProtos.Inventory.InventoryUpgradeTypeReflection.Descriptor, global::POGOProtos.Inventory.Item.ItemIdReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::POGOProtos.Inventory.InventoryUpgrade), global::POGOProtos.Inventory.InventoryUpgrade.Parser, new[]{ "ItemId", "UpgradeType", "AdditionalStorage" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class InventoryUpgrade : pb::IMessage<InventoryUpgrade> {
    private static readonly pb::MessageParser<InventoryUpgrade> _parser = new pb::MessageParser<InventoryUpgrade>(() => new InventoryUpgrade());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<InventoryUpgrade> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::POGOProtos.Inventory.InventoryUpgradeReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public InventoryUpgrade() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public InventoryUpgrade(InventoryUpgrade other) : this() {
      itemId_ = other.itemId_;
      upgradeType_ = other.upgradeType_;
      additionalStorage_ = other.additionalStorage_;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public InventoryUpgrade Clone() {
      return new InventoryUpgrade(this);
    }

    /// <summary>Field number for the "item_id" field.</summary>
    public const int ItemIdFieldNumber = 1;
    private global::POGOProtos.Inventory.Item.ItemId itemId_ = 0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::POGOProtos.Inventory.Item.ItemId ItemId {
      get { return itemId_; }
      set {
        itemId_ = value;
      }
    }

    /// <summary>Field number for the "upgrade_type" field.</summary>
    public const int UpgradeTypeFieldNumber = 2;
    private global::POGOProtos.Inventory.InventoryUpgradeType upgradeType_ = 0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::POGOProtos.Inventory.InventoryUpgradeType UpgradeType {
      get { return upgradeType_; }
      set {
        upgradeType_ = value;
      }
    }

    /// <summary>Field number for the "additional_storage" field.</summary>
    public const int AdditionalStorageFieldNumber = 3;
    private int additionalStorage_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int AdditionalStorage {
      get { return additionalStorage_; }
      set {
        additionalStorage_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as InventoryUpgrade);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(InventoryUpgrade other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ItemId != other.ItemId) return false;
      if (UpgradeType != other.UpgradeType) return false;
      if (AdditionalStorage != other.AdditionalStorage) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (ItemId != 0) hash ^= ItemId.GetHashCode();
      if (UpgradeType != 0) hash ^= UpgradeType.GetHashCode();
      if (AdditionalStorage != 0) hash ^= AdditionalStorage.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (ItemId != 0) {
        output.WriteRawTag(8);
        output.WriteEnum((int) ItemId);
      }
      if (UpgradeType != 0) {
        output.WriteRawTag(16);
        output.WriteEnum((int) UpgradeType);
      }
      if (AdditionalStorage != 0) {
        output.WriteRawTag(24);
        output.WriteInt32(AdditionalStorage);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (ItemId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) ItemId);
      }
      if (UpgradeType != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) UpgradeType);
      }
      if (AdditionalStorage != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(AdditionalStorage);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(InventoryUpgrade other) {
      if (other == null) {
        return;
      }
      if (other.ItemId != 0) {
        ItemId = other.ItemId;
      }
      if (other.UpgradeType != 0) {
        UpgradeType = other.UpgradeType;
      }
      if (other.AdditionalStorage != 0) {
        AdditionalStorage = other.AdditionalStorage;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 8: {
            itemId_ = (global::POGOProtos.Inventory.Item.ItemId) input.ReadEnum();
            break;
          }
          case 16: {
            upgradeType_ = (global::POGOProtos.Inventory.InventoryUpgradeType) input.ReadEnum();
            break;
          }
          case 24: {
            AdditionalStorage = input.ReadInt32();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
