//UMX Code Generated
/*
NOTE: THIS FILE CONTAINS AUTO GENERATED SOURCE CODE.
      ANY MANUAL CHANGES TO THIS FILE WILL BE OVERWRITTEN IF THE CODE GENERATOR IS RE-EXECUTED.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Opc.Ua;

namespace CodeGenerated
{
    public class CodeGenNodeFactory
    {
        public static CodeGenObjectTypeBase CreateObject(string szBrowseName,
                                                          string fileNoExtension,
                                                          string typeId, ushort typeNamespaceIndex, IdType typeNodeIdType,
                                                          string nodeId, ushort namespaceIndex, IdType nodeIdType,
                                                          string parentNodeId, ushort parentNamespaceIndex, IdType parentNodeIdType)
        {
            
            if (fileNoExtension == "type_ObjectType_RoomDTO_1054562535_0")
                return new ObjectType_RoomDTO_1054562535_0(szBrowseName,
                                    typeId, typeNamespaceIndex, typeNodeIdType,
                                    nodeId, namespaceIndex, nodeIdType,
                                    parentNodeId, parentNamespaceIndex, parentNodeIdType);
        
            
            if (fileNoExtension == "type_ObjectType_ServerRequest_111707335_0")
                return new ObjectType_ServerRequest_111707335_0(szBrowseName,
                                    typeId, typeNamespaceIndex, typeNodeIdType,
                                    nodeId, namespaceIndex, nodeIdType,
                                    parentNodeId, parentNamespaceIndex, parentNodeIdType);
        
            
            
            return null;
        }

        public static CodeGenVariableTypeBase CreateVariable(string szBrowseName,
                                                              string fileNoExtension,
                                                              string typeId, ushort typeNamespaceIndex, IdType typeNodeIdType,
                                                              string nodeId, ushort namespaceIndex, IdType nodeIdType,
                                                              string parentNodeId, ushort parentNamespaceIndex, IdType parentNodeIdType)
        {
            
            if (fileNoExtension == "type_VariableType_GoalTemperature_DTO_606346491_0")
                return new VariableType_GoalTemperature_DTO_606346491_0(szBrowseName,
                                    typeId, typeNamespaceIndex, typeNodeIdType,
                                    nodeId, namespaceIndex, nodeIdType,
                                    parentNodeId, parentNamespaceIndex, parentNodeIdType);
        
            
            if (fileNoExtension == "type_VariableType_ID_DTO_1134910354_0")
                return new VariableType_ID_DTO_1134910354_0(szBrowseName,
                                    typeId, typeNamespaceIndex, typeNodeIdType,
                                    nodeId, namespaceIndex, nodeIdType,
                                    parentNodeId, parentNamespaceIndex, parentNodeIdType);
        
            
            if (fileNoExtension == "type_VariableType_ActualTemperature_DTO_325685183_0")
                return new VariableType_ActualTemperature_DTO_325685183_0(szBrowseName,
                                    typeId, typeNamespaceIndex, typeNodeIdType,
                                    nodeId, namespaceIndex, nodeIdType,
                                    parentNodeId, parentNamespaceIndex, parentNodeIdType);
        
            
            if (fileNoExtension == "type_VariableType_Name_210620154030_14_784679566_0")
                return new VariableType_Name_210620154030_14_784679566_0(szBrowseName,
                                    typeId, typeNamespaceIndex, typeNodeIdType,
                                    nodeId, namespaceIndex, nodeIdType,
                                    parentNodeId, parentNamespaceIndex, parentNodeIdType);
        
            
            if (fileNoExtension == "type_VariableType_GoalTemp_662026670_0")
                return new VariableType_GoalTemp_662026670_0(szBrowseName,
                                    typeId, typeNamespaceIndex, typeNodeIdType,
                                    nodeId, namespaceIndex, nodeIdType,
                                    parentNodeId, parentNamespaceIndex, parentNodeIdType);
        
            
            if (fileNoExtension == "type_VariableType_RoomName_627147307_0")
                return new VariableType_RoomName_627147307_0(szBrowseName,
                                    typeId, typeNamespaceIndex, typeNodeIdType,
                                    nodeId, namespaceIndex, nodeIdType,
                                    parentNodeId, parentNamespaceIndex, parentNodeIdType);
        
            
            
            return null;
        }
        
        public static CodeGenMethodTypeBase CreateMethod(string szBrowseName,
                                                          string fileNoExtension,
                                                          string typeId, ushort typeNamespaceIndex, IdType typeNodeIdType,
                                                          string nodeId, ushort namespaceIndex, IdType nodeIdType,
                                                          string parentNodeId, ushort parentNamespaceIndex, IdType parentNodeIdType)
        {
            
            
            return null;
        }       
    }
}
