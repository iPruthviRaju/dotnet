///----------------------------------------------------------------------
/// <File>IPrintScanContent</File>
/// <Author>Pruthvi</Author>
/// <Date>August 3rd, 2018</Date>
/// <Summary></Summary>
///-----------------------------------------------------------------------

namespace ISP
{
    public interface IPrintScanContent
    {
        void PrintContent(string content);
        void ScanContent(string content);
        void PhotoCopyContent(string content);
    }
}
