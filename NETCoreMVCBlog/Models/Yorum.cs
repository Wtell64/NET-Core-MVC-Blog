﻿namespace NETCoreMVCBlog.Models
{
	public class Yorum
	{
		public string KullaniciAdi { get; set; }
		public DateTime Zaman { get; set; } = DateTime.Now;
		// Yoruma gelen Begeni sayisi
		public int BegenenSayisi { get; set; }

		// Yoruma gelen Begenmeme sayisi
		public int BegenmeyenSayisi { get; set; }
	}
}
