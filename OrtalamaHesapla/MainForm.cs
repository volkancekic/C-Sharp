/*
 * SharpDevelop tarafından düzenlendi.
 * Kullanıcı: V
 * Tarih: 10.1.2018
 * Zaman: 11:10
 * 
 * Bu şablonu değiştirmek için Araçlar | Seçenekler | Kodlama | Standart Başlıkları Düzenle 'yi kullanın.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace ortalamahesapla
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void MainFormLoad(object sender, EventArgs e)
		{
			
		}
		
		void Button2Click(object sender, EventArgs e)
		{
			
		}
		
		void Button3Click(object sender, EventArgs e)
		{
			int vize;
			int final;
			double ortalama;
			double but;
			double kurtarma;
			string mesaj;
			
		
			
			
				if(Convert.ToInt32(textBox1.Text)<0 || Convert.ToInt32(textBox1.Text)>100){
				mesaj="VİZE NOTUNUZ HATALI LÜTFEN TEKRAR GİRİNİZ.";
				 MessageBox.Show(mesaj);
				}
			
			vize=Convert.ToInt32(textBox1.Text);
			
			   if(Convert.ToInt32(textBox2.Text)<0 || Convert.ToInt32(textBox2.Text)>100){
			   mesaj="FİNAL NOTUNUZ HATALI LÜTFEN TEKRAR GİRİNİZ.";
				MessageBox.Show(mesaj);
			}
			final=Convert.ToInt32(textBox2.Text);
			
			if(vize<0 || vize >100)
				vize=0;
			if(final<0 || final >100)
				final=0;
			if(final<50){
				mesaj="FİNAL NOTUNUZ 50'NİN ALTINDA OLDUĞU İÇİN KALDINIZ.";
			     MessageBox.Show(mesaj);
		}
			ortalama=(double)(vize*40)/100 + (final*60)/100;
			if(ortalama>=59.50 && ortalama<=59.99){
				ortalama=60;
			}
			if(ortalama >=60){
				if(ortalama>=89.50 ){
				ortalama=Math.Round(ortalama,0);
			    mesaj="ORTALAMANIZ \" " +ortalama +" \"   , A1 İLE GEÇTİNİZ. TEBRİKLER.. ";
			     label3.Text=mesaj;
				}
				if(ortalama>=79.50 && ortalama<=89.49){
					ortalama=Math.Round(ortalama,0);
			    mesaj="ORTALAMANIZ \" " +ortalama +" \"   , A2 İLE GEÇTİNİZ. TEBRİKLER.. ";
			     label3.Text=mesaj;
				}
				if(ortalama>=69.50 && ortalama<=79.49){
					ortalama=Math.Round(ortalama,0);
			    mesaj="ORTALAMANIZ \" " +ortalama +" \"   , B1 İLE GEÇTİNİZ. TEBRİKLER.. ";
			    label3.Text=mesaj;
				}
				if(ortalama>=64.50 && ortalama<=69.49){
					ortalama=Math.Round(ortalama,0);
			    mesaj="ORTALAMANIZ \" " +ortalama +" \"   , B2 İLE GEÇTİNİZ. TEBRİKLER.. ";
			     label3.Text=mesaj;
				}
				if(ortalama>=60 && ortalama<=64.49){
					ortalama=Math.Round(ortalama,0);
			    mesaj="ORTALAMANIZ  \" " +ortalama +" \"  , C İLE GEÇTİNİZ. TEBRİKLER.. ";
			     label3.Text=mesaj;
				}
			} 
			 else {
			   
				but=60- (vize*40/100);
				kurtarma=but*100/60;
				kurtarma=Math.Round(kurtarma,0);
				if(kurtarma<50){
					kurtarma=50;
				}
				ortalama=Math.Round(ortalama,0);
			    mesaj="ORTALAMANIZ  \" " +ortalama +" \"  , KALDINIZ.\nGEÇEBİLMENİZ İÇİN BÜTÜNLEME SINAVINDAN  \" " +kurtarma +" \"  ALMANIZ GEREKİYOR.";
			     label3.Text=mesaj;
			} 
			 
			
		}
		
		void Label1Click(object sender, EventArgs e)
		{
			
		}
		
		void TextBox1TextChanged(object sender, EventArgs e)
		{
			
		}
	}
}
