using System;

namespace GarageAB
{
	class OccasionAB : VoitureAB
	{
		private int nbKm;
		private string dateMiseCirculation;

		/// <summary>
		/// Constructeur de la classe <see cref="OccasionAB"/>
		/// </summary>
		/// <param name="id"></param>
		/// <param name="marque"></param>
		/// <param name="modele"></param>
		/// <param name="puissance"></param>
		/// <param name="vitesseMax"></param>
		/// <param name="prix"></param>
		/// <param name="nbKm"></param>
		/// <param name="dateMiseCirculation"></param>
		public OccasionAB(int id, string marque, string modele, int puissance, int vitesseMax, int prix, int nbKm, string dateMiseCirculation) : base(id, marque, modele, puissance, vitesseMax, prix)
		{
			this.nbKm = nbKm;
			this.dateMiseCirculation = dateMiseCirculation;
		}

		/// <summary>
		/// Get le nombre de kilometres
		/// </summary>
		/// <returns>Le nombre de kilometres sous forme d'<see cref="int"/></returns>
		public int GetnbKm()
		{
			return nbKm;
		}

		/// <summary>
		/// Set le nombre de kilometres
		/// </summary>
		/// <param name="nbKm">Le nombre de kilometres</param>
		public void SetnbKm(int nbKm)
		{
			this.nbKm = nbKm;
		}

		/// <summary>
		/// Récupere la date de mise en circulation de la voiture
		/// </summary>
		/// <returns>La date de mise en circulation sous forme de <see cref="string"/></returns>
		public string GetdateMiseCirculation()
		{
			return dateMiseCirculation;
		}

		/// <summary>
		/// Set la date de mise en circulation de la voiture
		/// </summary>
		/// <param name="dateMiseCirculation">La date de mise en circulation de la voiture</param>
		public void SetdateMiseCirculation(string dateMiseCirculation)
		{
			this.dateMiseCirculation = dateMiseCirculation;
		}

		/// <inheritdoc/>
		public override void AfficherVehiculeAB()
		{
			Console.WriteLine($"VoitureAB {{id={GetId()},marque='{GetMarque()}',modele='{GetModele()}',puissance={GetPuissance()},vitesseMax={GetVitesseMax()},prix={GetPrix()},nbKm={GetnbKm()},dateMiseCirculation={GetdateMiseCirculation()}}}");
		}

	}
}
