//UMX Code Generated
/*
NOTE: THIS FILE CONTAINS AUTO GENERATED SOURCE CODE.
      ANY MANUAL CHANGES TO THIS FILE WILL BE OVERWRITTEN IF THE CODE GENERATOR IS RE-EXECUTED.
*/
//Browse name: ServerRequest


using System;
using System.Collections.Generic;
using System.Text;
using Opc.Ua;
using Opc.Ua.Server;

namespace CodeGenerated
{
    public class ObjectType_ServerRequest_111707335_0 : CodeGenObjectTypeBase
    {        
        public ObjectType_ServerRequest_111707335_0(string browseName,
                               string typeId, ushort typeNamespaceIndex, IdType typeNodeIdType,
                               string nodeId, ushort namespaceIndex, IdType nodeIdType,
                               string parentNodeId, ushort parentNamespaceIndex, IdType parentNodeIdType
                               ) : base(browseName, 
                                        typeId, typeNamespaceIndex, typeNodeIdType,
                                        nodeId, namespaceIndex, nodeIdType,
                                        parentNodeId, parentNamespaceIndex, parentNodeIdType)
        {
            //constructor
        }


        public override bool Initialize(Dictionary<CodeGenNodeID, CodeGenNodeID> childrenIDMap,
                                        CodeGenNodeManager addressSpaceMgr)
        {
            Console.WriteLine("ObjectType_ServerRequest_111707335_0::Initialize");

            bool success = true;   
            
            m_addressSpaceMgr = addressSpaceMgr;
            ushort namespaceIndex = 0;

            // Set attributes
            this.GetNode().BrowseName  = "ServerRequest";
            this.GetNode().DisplayName = "ServerRequest";
            this.GetNode().Description = "";
            this.GetNode().WriteMask = AttributeWriteMask.None
                                        
                                        
                                        
                                        
                                        
                                        
                                        
                                        ;
                                        
            //Create Children objects
            
            
            //Create Children variables
            
            
            //Create Children properties
            
            {
            string childBrowseName = "GoalTemp";
    string childFileNoExtension = "type_VariableType_GoalTemp_662026670_0";
    string childTypeDefId = "68";
    ushort childTypeDefNamespaceIndex = 0;
    ushort childTypeDefNodeIdType = 0;

    string childDataTypeId = "24";
    ushort childDataTypeNamespaceIndex =  (ushort)m_addressSpaceMgr.SystemContext.NamespaceUris.GetIndex("http://opcfoundation.org/UA/");
    ushort childDataTypeNodeIdType = 0;
    int childDataTypeValueRank = -1;
    string childDataTypeArrayDimension = "";

    string childSourceId = "GoalTemp";
    ushort childSourceNamespaceIndex =  (ushort)m_addressSpaceMgr.SystemContext.NamespaceUris.GetIndex("TemperatureHandler");
    ushort childSourceNodeIdType = 1;
    NodeId newChildId = Helper.CreateID(childrenIDMap, m_addressSpaceMgr,
                                        childSourceId, childSourceNamespaceIndex, (IdType)childSourceNodeIdType);

    var_GoalTemp_662026670_0 = (VariableType_GoalTemp_662026670_0)                                                                                            
            (m_addressSpaceMgr.CreateProperty(childrenIDMap,                                                            
                 this.GetNode(), childFileNoExtension, childBrowseName,                                                 
                 childSourceId, childSourceNamespaceIndex, (IdType)childSourceNodeIdType,             
	                newChildId.Identifier.ToString(), newChildId.NamespaceIndex, (IdType)newChildId.IdType, 
  	            m_nodeId, m_namespaceIndex, m_nodeIdType,                                                              
                 childDataTypeValueRank));                                                                              
    VariableType_GoalTemp_662026670_0 local = var_GoalTemp_662026670_0;
    m_addressSpaceMgr.AddPredefinedNodeExt(m_addressSpaceMgr.SystemContext, local.GetNode());

            local.SetDataType(childDataTypeId, childDataTypeNamespaceIndex, (IdType)childDataTypeNodeIdType);
            }
            
            {
            string childBrowseName = "RoomName";
    string childFileNoExtension = "type_VariableType_RoomName_627147307_0";
    string childTypeDefId = "68";
    ushort childTypeDefNamespaceIndex = 0;
    ushort childTypeDefNodeIdType = 0;

    string childDataTypeId = "24";
    ushort childDataTypeNamespaceIndex =  (ushort)m_addressSpaceMgr.SystemContext.NamespaceUris.GetIndex("http://opcfoundation.org/UA/");
    ushort childDataTypeNodeIdType = 0;
    int childDataTypeValueRank = -1;
    string childDataTypeArrayDimension = "";

    string childSourceId = "RoomName";
    ushort childSourceNamespaceIndex =  (ushort)m_addressSpaceMgr.SystemContext.NamespaceUris.GetIndex("TemperatureHandler");
    ushort childSourceNodeIdType = 1;
    NodeId newChildId = Helper.CreateID(childrenIDMap, m_addressSpaceMgr,
                                        childSourceId, childSourceNamespaceIndex, (IdType)childSourceNodeIdType);

    var_RoomName_627147307_0 = (VariableType_RoomName_627147307_0)                                                                                            
            (m_addressSpaceMgr.CreateProperty(childrenIDMap,                                                            
                 this.GetNode(), childFileNoExtension, childBrowseName,                                                 
                 childSourceId, childSourceNamespaceIndex, (IdType)childSourceNodeIdType,             
	                newChildId.Identifier.ToString(), newChildId.NamespaceIndex, (IdType)newChildId.IdType, 
  	            m_nodeId, m_namespaceIndex, m_nodeIdType,                                                              
                 childDataTypeValueRank));                                                                              
    VariableType_RoomName_627147307_0 local = var_RoomName_627147307_0;
    m_addressSpaceMgr.AddPredefinedNodeExt(m_addressSpaceMgr.SystemContext, local.GetNode());

            local.SetDataType(childDataTypeId, childDataTypeNamespaceIndex, (IdType)childDataTypeNodeIdType);
            }
            
            
            //Create Children methods
            
            
            
            return success;
        }

        public override BaseObjectState GetNode()
        {
            return m_node;
        }

        public override void SetNode(BaseObjectState node)
        {
            m_node  = node;
            m_inode = node;
        }
        
        #region Public Fields
        /* Children objects */  
        

            /* Children variables */
        

            /* Children properties */
            public VariableType_GoalTemp_662026670_0 var_GoalTemp_662026670_0;
    public VariableType_RoomName_627147307_0 var_RoomName_627147307_0;


            /* Children methods */
        
        #endregion
    }
}
