using System;

namespace ZRA_VSDC_API.Models.Dto;

public class Data
{
    public static List<Code> codes = [
            new() {
                TPin=1, BHFID=4, LastReqDt=DateTime.Now, CdCls="", CdClsNm="", Cd="", CdNm="", 
                UserDfnNm1=""},
            new() {
                TPin=2, BHFID=5, LastReqDt=DateTime.Now, CdCls="", CdClsNm="", Cd="", CdNm="", 
                UserDfnNm1=""},
        ];

    public static List<Item> items = [
        new () {
            TPin=1, BHFID=1, Bcd ="", ItemCd="",ItemClsCd="",ItemTyCd=1,ItemNm="",ItemStdNm="",
            OrgnNatCd="",PkgUnitCd="",QtyUnitCd="",VatCatCd="",IplCatCd="",TlCatCd="",ExciseTxCatCd="",
            BtchNo="",DftPrc = 2.5,AddInfo="",SftyQty=0,IsrcAplcbYn="",UseYn="",RegrNm="",RegrId="",
            ModrNm="",ModrId=""
            },
        new () {
            TPin=2, BHFID=2, Bcd ="", ItemCd="",ItemClsCd="",ItemTyCd=2,ItemNm="",ItemStdNm="",
            OrgnNatCd="",PkgUnitCd="",QtyUnitCd="",VatCatCd="",IplCatCd="",TlCatCd="",ExciseTxCatCd="",
            BtchNo="",DftPrc = 2.5,AddInfo="",SftyQty=0,IsrcAplcbYn="",UseYn="",RegrNm="",RegrId="",
            ModrNm="",ModrId=""
            },
            new () {
            TPin=3, BHFID=3, Bcd ="", ItemCd="",ItemClsCd="",ItemTyCd=3,ItemNm="",ItemStdNm="",
            OrgnNatCd="",PkgUnitCd="",QtyUnitCd="",VatCatCd="",IplCatCd="",TlCatCd="",ExciseTxCatCd="",
            BtchNo="",DftPrc = 2.5,AddInfo="",SftyQty=0,IsrcAplcbYn="",UseYn="",RegrNm="",RegrId="",
            ModrNm="",ModrId=""
            }
    ];

    public static List<Device> devices = [
        new() {
            TPin=1, TaxprNm="", BsnsActv="", BhfId="",BhfNm="",BhfOpenDt=DateTime.Now,PrvncNm="",
            DstrtNm="", SctrNm="", LocDesc="", HqYn="", MgrNm="", MgrTelNo="", MgrEmail="", SdcId="",
            MrcNo="", LastPchsInvcNo=1, LastSaleRcptNo=1, LastInvcNo=1, LastSaleInvcNo=1, LastTrainInvcNo=1,
            LastProfrmInvcNo=1, LastCopyInvcNo=1
        },
        new() {
            TPin=1, TaxprNm="", BsnsActv="", BhfId="",BhfNm="",BhfOpenDt=DateTime.Now,PrvncNm="",
            DstrtNm="", SctrNm="", LocDesc="", HqYn="", MgrNm="", MgrTelNo="", MgrEmail="", SdcId="",
            MrcNo="", LastPchsInvcNo=2, LastSaleRcptNo=2, LastInvcNo=2, LastSaleInvcNo=2, LastTrainInvcNo=2,
            LastProfrmInvcNo=2, LastCopyInvcNo=2
        }
    ];

    public static List<Import> imports = [
        new() {
            TaskCd="", DclDe=1, ItemSeq=1, DclNo="", HsCd="", ItemNm="", ImptItemsttsCd="", OrgnNatCd="",
            ExptNatCd="", Pkg=1, PkgUnitCd="", Qty=1, QtyUnitCd="", TotWt=1.2, NetWt=1.2, SpplrNm="", AgntNm="",
            InvcFcurAmt=1.2, InvcFcurCd="", InvcFcurExcrt=1.2
        },
        new() {
            TaskCd="", DclDe=2, ItemSeq=2, DclNo="", HsCd="", ItemNm="", ImptItemsttsCd="", OrgnNatCd="",
            ExptNatCd="", Pkg=2, PkgUnitCd="", Qty=2, QtyUnitCd="", TotWt=2.2, NetWt=2.2, SpplrNm="", AgntNm="",
            InvcFcurAmt=2.2, InvcFcurCd="", InvcFcurExcrt=2.2
        },
    ];
}
