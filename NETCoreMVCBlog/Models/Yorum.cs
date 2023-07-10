namespace NETCoreMVCBlog.Models
{
	public class Yorum
	{
		public string KullaniciAdi { get; set; }
		public DateTime Zaman { get; set; } = DateTime.Now;

		public int BegenenSayisi { get; set; }
		public int BegenmeyenSayisi { get; set; }
	}
}
