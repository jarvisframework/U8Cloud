using Newtonsoft.Json;
using System.Collections.Generic;
using YX.Utility.Common;

namespace YX.Utility.U8Cloud.Response
{
    public class InvmandocQueryResponse : U8CloudResponse
    {
        public DataDomain<BillVO> dataDomain { get; set; }

        public override void ParseData()
        {
            dataDomain = data.ToModel<DataDomain<BillVO>>();
        }

        /// <summary>
        /// 判断是否存在下一页
        /// </summary>
        /// <param name="pageNow"></param>
        /// <param name="pageSize"></param>
        /// <returns></returns>
        public bool IsExistNextPage(int pageNow, int pageSize) {
            return (pageNow * pageSize) < dataDomain.allcount;
        }

        public class BillVO {
            
            public ParentVO parentvo { get; set; }
            
            public List<object> bodymeas { get; set; }
            
            public List<object> invrepl { get; set; }
            
            [JsonProperty("bd_invbindle")]
            public List<object> bdInvbindle { get; set; }

            public class ParentVO
            {
                
                public InvbasVo invbasVo { get; set; }
                
                public InvmanVo invmanVo { get; set; }

                public class InvbasVo
                {
                    /// <summary>
                    /// 
                    /// </summary>
                    public string invcode { get; set; }
                    /// <summary>
                    /// 
                    /// </summary>
                    public string invname { get; set; }
                    /// <summary>
                    /// 
                    /// </summary>
                    public string invtype { get; set; }
                    /// <summary>
                    /// 
                    /// </summary>
                    [JsonProperty("pk_invcl")]
                    public string pkInvcl { get; set; }
                    /// <summary>
                    /// 
                    /// </summary>
                    public string invclcode { get; set; }
                    /// <summary>
                    /// 
                    /// </summary>
                    public string invclname { get; set; }
                    /// <summary>
                    /// 
                    /// </summary>
                    [JsonProperty("pk_measdoc")]
                    public string pkMeasdoc { get; set; }
                    /// <summary>
                    /// 
                    /// </summary>
                    public string meascode { get; set; }
                    /// <summary>
                    /// 
                    /// </summary>
                    public string measname { get; set; }
                    /// <summary>
                    /// 
                    /// </summary>
                    [JsonProperty("pk_taxitems")]
                    public string pkTaxitems { get; set; }
                    /// <summary>
                    /// 
                    /// </summary>
                    public string taxitemscode { get; set; }
                    /// <summary>
                    /// 
                    /// </summary>
                    public string taxitemsname { get; set; }
                    /// <summary>
                    /// 
                    /// </summary>
                    public string memo { get; set; }
                    /// <summary>
                    /// 
                    /// </summary>
                    public decimal unitvolume { get; set; }
                    /// <summary>
                    /// 
                    /// </summary>
                    public decimal unitweight { get; set; }
                    /// <summary>
                    /// 
                    /// </summary>
                    public string laborflag { get; set; }
                    /// <summary>
                    /// 
                    /// </summary>
                    public string discountflag { get; set; }
                    /// <summary>
                    /// 
                    /// </summary>
                    public string setpartsflag { get; set; }
                    /// <summary>
                    /// 
                    /// </summary>
                    public string asset { get; set; }
                    /// <summary>
                    /// 
                    /// </summary>
                    public string iselectrans { get; set; }
                    /// <summary>
                    /// 
                    /// </summary>
                    public string isretail { get; set; }
                    /// <summary>
                    /// 
                    /// </summary>
                    public string assistunit { get; set; }
                    /// <summary>
                    /// 
                    /// </summary>
                    public string autobalancemeas { get; set; }
                    /// <summary>
                    /// 
                    /// </summary>
                    public string ismngstockbygrswt { get; set; }
                    /// <summary>
                    /// 
                    /// </summary>
                    public string isstorebyconvert { get; set; }
                    /// <summary>
                    /// 
                    /// </summary>
                    public string creator { get; set; }
                    /// <summary>
                    /// 
                    /// </summary>
                    public string creatorname { get; set; }
                    /// <summary>
                    /// 
                    /// </summary>
                    public string createtime { get; set; }
                    /// <summary>
                    /// 
                    /// </summary>
                    [JsonProperty("pk_invbasdoc")]
                    public string pkInvbasdoc { get; set; }
                    /// <summary>
                    /// 
                    /// </summary>
                    public string ts { get; set; }
                    /// <summary>
                    /// 
                    /// </summary>
                    [JsonProperty("pk_corp")]
                    public string pkCorp { get; set; }
                    /// <summary>
                    /// 
                    /// </summary>
                    public string unitcode { get; set; }
                    /// <summary>
                    /// 
                    /// </summary>
                    public string unitname { get; set; }
                    /// <summary>
                    /// 
                    /// </summary>
                    public string dr { get; set; }
                }

                public class InvmanVo
                {
                    /// <summary>
                    /// 
                    /// </summary>
                    public string abctype { get; set; }
                    /// <summary>
                    /// 
                    /// </summary>
                    public string accflag { get; set; }
                    /// <summary>
                    /// 
                    /// </summary>
                    public string consumesettleflag { get; set; }
                    /// <summary>
                    /// 
                    /// </summary>
                    public string createtime { get; set; }
                    /// <summary>
                    /// 
                    /// </summary>
                    public string creator { get; set; }
                    /// <summary>
                    /// 
                    /// </summary>
                    public string creatorname { get; set; }
                    /// <summary>
                    /// 
                    /// </summary>
                    public string dr { get; set; }
                    /// <summary>
                    /// 
                    /// </summary>
                    public decimal expaybacktax { get; set; }
                    /// <summary>
                    /// 
                    /// </summary>
                    public string invlifeperiod { get; set; }
                    /// <summary>
                    /// 
                    /// </summary>
                    public string isappendant { get; set; }
                    /// <summary>
                    /// 
                    /// </summary>
                    public string isautoatpcheck { get; set; }
                    /// <summary>
                    /// 
                    /// </summary>
                    public string iscancalculatedinvcost { get; set; }
                    /// <summary>
                    /// 
                    /// </summary>
                    public string iscanpurchased { get; set; }
                    /// <summary>
                    /// 
                    /// </summary>
                    public string iscansaleinvoice { get; set; }
                    /// <summary>
                    /// 
                    /// </summary>
                    public string iscansold { get; set; }
                    /// <summary>
                    /// 
                    /// </summary>
                    public string isconfigable { get; set; }
                    /// <summary>
                    /// 
                    /// </summary>
                    public string isctlprodplanprice { get; set; }
                    /// <summary>
                    /// 
                    /// </summary>
                    public string isfatherofbom { get; set; }
                    /// <summary>
                    /// 
                    /// </summary>
                    public string isinvretfreeofchk { get; set; }
                    /// <summary>
                    /// 
                    /// </summary>
                    public string isinvretinstobychk { get; set; }
                    /// <summary>
                    /// 
                    /// </summary>
                    public string isinvreturned { get; set; }
                    /// <summary>
                    /// 
                    /// </summary>
                    public string isnoconallowed { get; set; }
                    /// <summary>
                    /// 
                    /// </summary>
                    public string isprimarybarcode { get; set; }
                    /// <summary>
                    /// 
                    /// </summary>
                    public string isrecurrentcheck { get; set; }
                    /// <summary>
                    /// 
                    /// </summary>
                    public string issalable { get; set; }
                    /// <summary>
                    /// 
                    /// </summary>
                    public string issecondarybarcode { get; set; }
                    /// <summary>
                    /// 
                    /// </summary>
                    public string isselfapprsupplier { get; set; }
                    /// <summary>
                    /// 
                    /// </summary>
                    public string isspecialty { get; set; }
                    /// <summary>
                    /// 
                    /// </summary>
                    public string issupplierstock { get; set; }
                    /// <summary>
                    /// 
                    /// </summary>
                    public string isused { get; set; }
                    /// <summary>
                    /// 
                    /// </summary>
                    public string isvirtual { get; set; }
                    /// <summary>
                    /// 
                    /// </summary>
                    public decimal keepwasterate { get; set; }
                    /// <summary>
                    /// 
                    /// </summary>
                    public decimal lowestprice { get; set; }
                     
                    public decimal maxprice { get; set; }
                    /// <summary>
                    /// 
                    /// </summary>
                    public string negallowed { get; set; }
                    /// <summary>
                    /// 
                    /// </summary>
                    public string outpriority { get; set; }
                    /// <summary>
                    /// 
                    /// </summary>
                    public string outtrackin { get; set; }
                    /// <summary>
                    /// 
                    /// </summary>
                    [JsonProperty("pk_corp")]
                    public string pkCorp { get; set; }
                    /// <summary>
                    /// 
                    /// </summary>
                    public string unitcode { get; set; }
                    /// <summary>
                    /// 
                    /// </summary>
                    public string unitname { get; set; }
                    /// <summary>
                    /// 
                    /// </summary>
                    [JsonProperty("pk_invbasdoc")]
                    public string pkInvbasdoc { get; set; }
                    /// <summary>
                    /// 
                    /// </summary>
                    [JsonProperty("pk_invmandoc")]
                    public string pkInvmandoc { get; set; }
                    /// <summary>
                    /// 
                    /// </summary>
                    public string purchasestge { get; set; }
                    /// <summary>
                    /// 
                    /// </summary>
                    public int purwasterate { get; set; }
                    /// <summary>
                    /// 
                    /// </summary>
                    public string qualitymanflag { get; set; }
                    /// <summary>
                    /// 
                    /// </summary>
                    public string qualityperiodunit { get; set; }
                    /// <summary>
                    /// 
                    /// </summary>
                    public string sealflag { get; set; }
                    /// <summary>
                    /// 
                    /// </summary>
                    public string sellproxyflag { get; set; }
                    /// <summary>
                    /// 
                    /// </summary>
                    public string serialmanaflag { get; set; }
                    /// <summary>
                    /// 
                    /// </summary>
                    public string ts { get; set; }
                    /// <summary>
                    /// 
                    /// </summary>
                    public string wholemanaflag { get; set; }
                }
            }
        }
    }
}