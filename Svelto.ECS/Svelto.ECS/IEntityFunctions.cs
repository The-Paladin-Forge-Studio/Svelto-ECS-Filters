namespace Svelto.ECS {
    public interface IEntityFunctions
    {
        //being entity ID globally not unique, the group must be specified when
        //an entity is removed. Not specifying the group will attempt to remove
        //the entity from the special standard group.
        void RemoveEntity<T>(uint entityID, ExclusiveGroupStruct groupID) where T : IEntityDescriptor, new();
        void RemoveEntity<T>(EGID entityegid) where T : IEntityDescriptor, new();
        
        void RemoveEntitiesFromGroup(ExclusiveGroupStruct groupID);

        void SwapEntitiesInGroup<T>(ExclusiveGroupStruct fromGroupID, ExclusiveGroupStruct toGroupID)  where T : IEntityDescriptor, new();

        void SwapEntityGroup<T>(uint entityID, ExclusiveGroupStruct fromGroupID, ExclusiveGroupStruct toGroupID)
            where T : IEntityDescriptor, new();

        void SwapEntityGroup<T>(EGID fromID, ExclusiveGroupStruct toGroupID) where T : IEntityDescriptor, new();

        void SwapEntityGroup<T>(EGID fromID, ExclusiveGroupStruct toGroupID, ExclusiveGroupStruct mustBeFromGroup)
            where T : IEntityDescriptor, new();

        void SwapEntityGroup<T>(EGID fromID, EGID toId) where T : IEntityDescriptor, new();

        void SwapEntityGroup<T>(EGID fromID, EGID toId, ExclusiveGroupStruct mustBeFromGroup)
            where T : IEntityDescriptor, new();
#if UNITY_NATIVE
        NativeEntityRemove ToNativeRemove<T>(string memberName)  where T : IEntityDescriptor, new();
        NativeEntitySwap ToNativeSwap<T>(string memberName)  where T : IEntityDescriptor, new();
#endif        
    }
}