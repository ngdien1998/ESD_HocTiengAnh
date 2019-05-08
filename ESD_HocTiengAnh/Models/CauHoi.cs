namespace ESD_HocTiengAnh.Models
{
    public class CauHoi
    {
        public int IdCauHoi { get; set; }
        public string NoiDung { get; set; }
        public int IdChuDe { get; set; }

        public virtual ChuDe ChuDe => ChuDe.Data.Find(e => e.IdChude == IdChuDe);
    }
}