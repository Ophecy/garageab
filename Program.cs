namespace GarageAB
{
	class Program
	{
		static void Main(string[] args)
		{
			VoitureAB vehicule1 = new VoitureAB(1, "Renault", "Kangoo", 115, 190, 25000);
			VoitureAB vehicule2 = new VoitureAB(2, "Peugeot", "2008", 120, 200, 29000);
			OccasionAB vehicule3 = new OccasionAB(3, "Volkswagen", "Kangoo", 115, 190, 25000, 110000, "2010");
			OccasionAB vehicule4 = new OccasionAB(4, "Audi", "Kangoo", 115, 190, 25000, 250000, "2001");
			OccasionAB vehicule5 = new OccasionAB(5, "McLaren", "Senna", 800, 340, 930000, 800, "14/05/2018");
			vehicule1.AfficherVehiculeAB();
			vehicule5.AfficherVehiculeAB();

		}
	}
}
