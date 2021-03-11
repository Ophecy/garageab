using System;
using System.Collections.Generic;

namespace GarageAB
{
	/// <summary>
	/// Classe voiture
	/// </summary>
	class VoitureAB
	{
		protected int id;
		protected string marque;
		protected string modele;
		protected int puissance;
		protected int vitesseMax;
		protected int prix;

		/// <summary>
		/// Get l'**ID** de cette instance de l'objet voiture
		/// </summary>
		/// <returns>L'**ID** sous forme d'<see cref="int"/></returns>
		public int GetId()
		{
			return id;
		}

		/// <summary>
		/// Set l'**ID**
		/// </summary>
		/// <param name="id"></param>
		public void SetId(int id)
		{
			this.id = id;
		}

		/// <summary>
		/// Get la marque de la voiture 
		/// </summary>
		/// <returns>la marque de la voiture sous forme de <see cref="string"/></returns>
		public string GetMarque()
		{
			return marque;
		}

		/// <summary>
		/// Set la marque de la voiture 
		/// </summary>
		/// <param name="marque"></param>
		public void SetMarque(string marque)
		{
			this.marque = marque;
		}

		/// <summary>
		/// Get le modele de la voiture
		/// </summary>
		/// <returns>Le modele sous forme de <see cref="string"/></returns>
		public string GetModele()
		{
			return modele;
		}

		/// <summary>
		/// Set le modele de la voiture
		/// </summary>
		/// <param name="modele">Le modele de la voiture</param>
		public void SetModele(string modele)
		{
			this.modele = modele;
		}

		/// <summary>
		/// Get la puissance de la voiture en nombre de ch
		/// </summary>
		/// <returns>La puissance sous forme de <see cref="int"/></returns>
		public int GetPuissance()
		{
			return puissance;
		}

		/// <summary>
		/// Set la puissance de la voiture
		/// </summary>
		/// <param name="puissance">La puissance de la voiture</param>
		public void SetPuissance(int puissance)
		{
			this.puissance = puissance;
		}

		/// <summary>
		/// Get la vitesse max de la voiture
		/// </summary>
		/// <returns>la vitesse de la voiture sous forme d'<see cref="int"/></returns>
		public int GetVitesseMax()
		{
			return vitesseMax;
		}

		/// <summary>
		/// Set la vitesse max de la voiture
		/// </summary>
		/// <param name="vitesseMax">La vitesse de la voiture</param>
		public void SetVitesseMax(int vitesseMax)
		{
			this.vitesseMax = vitesseMax;
		}

		/// <summary>
		/// Get le prix en €
		/// </summary>
		/// <returns>Le prix sous forme d'<see cref="int"/></returns>
		public int GetPrix()
		{
			return prix;
		}

		/// <summary>
		/// Set le prix
		/// </summary>
		/// <param name="prix">Le prix de la voiture</param>
		public void SetPrix(int prix)
		{
			this.prix = prix;
		}

		/// <summary>
		/// Affiche le résume de la voiture au format JSON
		/// </summary>
		public virtual void AfficherVehiculeAB()
		{
			Console.WriteLine($"VoitureAB {{id={GetId()},marque='{GetMarque()}',modele='{GetModele()}',puissance={GetPuissance()},vitesseMax={GetVitesseMax()},prix={GetPrix()}}}");
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
			this.SetId(id);
			this.SetMarque(marque);
			this.SetModele(modele);
			this.SetPuissance(puissance);
			this.SetVitesseMax(vitesseMax);
			this.SetPrix(prix);
		}
	}
}
