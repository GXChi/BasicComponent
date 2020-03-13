using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace DataHelper
{
    [Serializable, StructLayout(LayoutKind.Sequential)]
    public struct CommandInfo
    {
        public string InsertText { get; set; }
        public string UpdateText { get; set; }
        public string DeleteText { get; set; }
        public string SelectText { get; set; }
        public string PagingText { get; set; }
        public string CounterText { get; set; }

        public CommandType InsertType { get; set; }
        public CommandType UpdateType { get; set; }
        public CommandType DeleteType { get; set; }
        public CommandType SelectType { get; set; }
        public CommandType PagingType { get; set; }
        public CommandType CounterType { get; set; }

        public List<ParamInfo> InsertParams { get; set; }
        public List<ParamInfo> UpdateParams { get; set; }
        public List<ParamInfo> DeleteParams { get; set; }
        public List<ParamInfo> SelectParams { get; set; }
        public List<ParamInfo> PagingParams { get; set; }
        public List<ParamInfo> CounterParams { get; set; }

        public string PageSizeParamName { get; set; }
        public string PageIndexParamName { get; set; }
        public string SelectAndFlag { get; set; }
        public string UpdateAndFlag { get; set; }
        public string DeleteAndFlag { get; set; }
        public string PagingAndFlag { get; set; }
        public string CounterAndFlag { get; set; }
        public string SortFlag { get; set; }
        public string DefaultSort { get; set; }

        public CommandInfo(string insertText, string updateText, string deleteText, string selectText, CommandType insertType, CommandType updateType, CommandType deleteType, CommandType selectType, List<ParamInfo> insertParams, List<ParamInfo> updateParams, List<ParamInfo> deleteParams, List<ParamInfo> selectParams, string pagingText, CommandType pagingType, List<ParamInfo> pagingParams, string pageSizeParamName, string pageIndexParamName, string counterText, CommandType counterType, List<ParamInfo> counterParams, string selectAndFlag, string updateAndFlag, string deleteAndFlag, string pagingAndFlag, string counterAndFlag, string sortFlag, string defaultSort)
        {
            this.InsertText = insertText;
            this.UpdateText = updateText;
            this.DeleteText = deleteText;
            this.SelectText = selectText;
            this.PagingText = pagingText;
            this.CounterText = counterText;

            this.InsertType = insertType;
            this.UpdateType = updateType;
            this.DeleteType = deleteType;
            this.SelectType = selectType;
            this.PagingType = pagingType;
            this.CounterType = counterType;

            this.InsertParams = insertParams;
            this.UpdateParams = updateParams;
            this.DeleteParams = deleteParams;
            this.SelectParams = selectParams;
            this.PagingParams = pagingParams;
            this.CounterParams = counterParams;

            this.PageSizeParamName = pageSizeParamName;
            this.PageIndexParamName = pageIndexParamName;            
            this.SelectAndFlag = selectAndFlag;
            this.UpdateAndFlag = updateAndFlag;
            this.DeleteAndFlag = deleteAndFlag;
            this.PagingAndFlag = pagingAndFlag;
            this.CounterAndFlag = counterAndFlag;
            this.SortFlag = sortFlag;
            this.DefaultSort = defaultSort;
        }

    }
}
