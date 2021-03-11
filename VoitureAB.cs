using System;

namespace GarageAB
{
	/// <summary>
	/// Classe voiture
	/// </summary>
	class VoitureAB
	{
		private int id;
		private string marque;
		private string modele;
		private int puissance;
		private int vitesseMax;
		private int prix;
		/// <summary>
		/// Permet de get ***l'id***
		/// </summary>
		/// <returns>renvoie l'id</returns>
		public int Getid()
		{
			return id;
		}

		/// <summary>
		/// permet de set **l'id**
		/// </summary>
		/// <param name="value"></param>
		public void Setid(int value)
		{
			id = value;
		}

		/// <summary>
		/// permet de get la *marque*
		/// </summary>
		/// <returns>renvoie la marque</returns>
		public string Getmarque()
		{
			return marque;
		}

		/// <summary>
		/// permet de set la marque
		/// </summary>
		/// <param name="value"></param>
		public void Setmarque(string value)
		{
			marque = value;
		}

		/// <summary>
		/// Affiche le résume de la voiture au format JSON
		/// </summary>
		public virtual void AfficherVehiculeAB()
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
		/// <summary>
		/// Constructeur de la classe voiture
		/// </summary>
		/// <param name="id"></param>
		/// <param name="marque"></param>
		/// <param name="modele"></param>
		/// <param name="puissance"></param>
		/// <param name="vitesseMax"></param>
		/// <param name="prix"></param>
		public VoitureAB(int id, string marque, string modele, int puissance, int vitesseMax, int prix)
		{
			this.Setid(id);
			this.Setmarque(marque);
			this.Setmodele(modele);
			this.Setpuissance(puissance);
			this.SetvitesseMax(vitesseMax);
			this.Setprix(prix);
		}
	}
}
