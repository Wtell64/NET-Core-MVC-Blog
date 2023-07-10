using System.Collections.Generic;

namespace NETCoreMVCBlog.Models
{
	public class Gonderi
	{

		public string Baslik { get; set; }

		public string Icerik { get; set; }

		public DateTime YaratilmaZamani { get; set; } = DateTime.Now;

		public List<Yorum> Yorumlar { get; set; } = new List<Yorum>();

		// Yoruma gelen Begeni sayisi
		public int BegenenSayisi { get; set; }

		// Yoruma gelen Begenmeme sayisi
		public int BegenmeyenSayisi { get; set; }
	}
}
