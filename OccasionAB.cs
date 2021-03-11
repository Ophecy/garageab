using System;

namespace GarageAB
{
	class OccasionAB : VoitureAB
	{
		private int nbKm;
		private string dateMiseCirculation;

		public OccasionAB(int id, string marque, string modele, int puissance, int vitesseMax, int prix, int nbKm, string dateMiseCirculation) : base(id, marque, modele, puissance, vitesseMax, prix)
		{
			this.nbKm = nbKm;
			this.dateMiseCirculation = dateMiseCirculation;
		}

		/// <summary>
		/// Get le nombre de killometres
		/// </summary>
		/// <returns></returns>
		public int GetnbKm()
		{
			return nbKm;
		}

		/// <summary>
		/// Set le nombre de kilometres
		/// </summary>
		/// <param name="value"></param>
		public void SetnbKm(int value)
		{
			nbKm = value;
		}

		public string GetdateMiseCirculation()
		{
			return dateMiseCirculation;
		}

		public void SetdateMiseCirculation(string value)
		{
			dateMiseCirculation = value;
		}

		public override void AfficherVehiculeAB()
		{
			Console.WriteLine("VoitureAB{",
			"id=", Getid(),
			", marque='", Getmarque(), '\'',
			", modele='", Getmodele(), '\'',
			", puissance=", Getpuissance(),
			", vitesseMax=", GetvitesseMax(),
			", prix=", Getprix(),
			'}'
			);
		}

	}
}
