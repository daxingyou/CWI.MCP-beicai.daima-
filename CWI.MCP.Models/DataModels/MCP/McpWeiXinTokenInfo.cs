//---------------------------------------------
// 版权信息：版权所有(C) 2014，COOLWI.COM
// 变更历史：
//      姓名          日期              说明
// --------------------------------------------
//      王军锋        2014/08/20        创建
//---------------------------------------------

using System;
using Evt.Framework.Common;
using Evt.Framework.DataAccess;

namespace CWI.MCP.Models
{
    /// <summary>
    /// 微信令牌实体类
    /// </summary>
    [Serializable]
    [TableMapping(TableName = "mcp_weixin_token")]
    public partial class McpWeiXinTokenInfo : Model
    {
        /// <summary>
        /// 物理字段：id
        /// </summary>
        [TableMapping(FieldName = "id", PrimaryKey = true)]
        public long Id { get; set; }

        /// <summary>
        /// 物理字段：app_id
        /// </summary>
        [TableMapping(FieldName = "app_id")]
        public string AppId { get; set; }

        /// <summary>
        /// 物理字段：access_token
        /// </summary>
        [TableMapping(FieldName = "access_token")]
        public string AccessToken { get; set; }

        /// <summary>
        /// 物理字段：expires_time
        /// </summary>
        [TableMapping(FieldName = "expires_time")]
        public int ExpiresTime { get; set; }

        /// <summary>
        /// 物理字段：update_time
        /// </summary>
        [TableMapping(FieldName = "update_time")]
        public DateTime UpdateTime { get; set; }
    }
}

