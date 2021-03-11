package com.garageab;

public class OccasionAB extends VoitureAB {
  private int nbKM;
  private String dateMiseCirculation;

  public OccasionAB(int id, String marque, String modele, int puissance, int vitesseMax, int prix, int nbKM, String dateMiseCirculation) {
    super(id, marque, modele, puissance, vitesseMax, prix);
    this.nbKM = nbKM;
    this.dateMiseCirculation = dateMiseCirculation;
  }

  /**
   * Get le nombre de km de la voiture
   * @return Le nombre de km sous forme d'entier
   */
  public int getNbKM() {
    return nbKM;
  }

  /**
   * Set le nombre de km de la voiture sous forme d'entier
   * @param nbKM Le nombre de kilometres
   */
  public void setNbKM(int nbKM) {
    this.nbKM = nbKM;
  }

  /**
   * Get la date de mise en circulation de la voiture
   * @return La date de mise en circulation de la voiture sous forme de string
   */
  public String getDateMiseCirculation() {
    return dateMiseCirculation;
  }

  /**
   * Set la date de mise en circulation de la voiture
   * @param dateMiseCirculation La date de mise en circulation de la voiture
   */
  public void setDateMiseCirculation(String dateMiseCirculation) {
    this.dateMiseCirculation = dateMiseCirculation;
  }

  @Override
  /**
   * {@inheritDoc}
   */
  public void afficherVehiculeAB() {
    System.out.println("OccasionAB{" +
            "nbKM=" + nbKM +
            ", dateMiseCirculation='" + dateMiseCirculation + '\'' +
            ", id=" + id +
            ", marque='" + marque + '\'' +
            ", modele='" + modele + '\'' +
            ", puissance=" + puissance +
            ", vitesseMax=" + vitesseMax +
            ", prix=" + prix +
            '}');
  }
}
