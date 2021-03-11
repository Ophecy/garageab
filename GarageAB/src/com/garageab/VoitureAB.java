package com.garageab;

/**
 * @author arthur
 * @version 1.0
 */
public class VoitureAB {
  protected int id;
  protected String marque;
  protected String modele;
  protected int puissance;
  protected int vitesseMax;
  protected int prix;


  /**
   * Le constructeur de la class voiture
   * @param id
   * @param marque
   * @param modele
   * @param puissance
   * @param vitesseMax
   * @param prix
   */
  public VoitureAB(int id, String marque, String modele, int puissance, int vitesseMax, int prix) {
    this.id = id;
    this.marque = marque;
    this.modele = modele;
    this.puissance = puissance;
    this.vitesseMax = vitesseMax;
    this.prix = prix;
  }

  /**
   * Get <i>l'ID</i> d'une voiture
   * @return L'ID de la voiture sous forme d'entier
   */
  public int getId() {
    return id;
  }

  /**
   * Set <b>l'ID</b> de la voiture
   * @param id l'ID de la voiture
   * @deprecated Preferer la méthode newSetId
   */
  public void setId(int id) {
    this.id = id;
  }
  /**
   * Set <b>l'ID</b> de la voiture
   * @param id L'id de la voiture
   * @since 1.0
   */
  public void newSetId(int id) {
    this.id = id;
  }

  /**
   * Get la marque de la voiture
   * @return La marque de la voiture
   */
  public String getMarque() {
    return marque;
  }

  /**
   * Set la marque de la voiture
   * @param marque La marque de la voiture
   */
  public void setMarque(String marque) {
    this.marque = marque;
  }

  /**
   * Get le modele de la voiture
   * @return Le modele sous forme de String
   */
  public String getModele() {
    return modele;
  }

  /**
   * Set le modele de la voiture
   * @param modele Le modele de la voiture
   */
  public void setModele(String modele) {
    this.modele = modele;
  }

  /**
   * Get la puissance de la voiture
   * @return La puissance de la voiture
   */
  public int getPuissance() {
    return puissance;
  }

  /**
   * Set la puissance de la voiture
   * @param puissance La puissance de la voiture
   */
  public void setPuissance(int puissance) {
    this.puissance = puissance;
  }

  /**
   * Get la vitesse max de la voiture
   * @return La vitesse max de la voiture
   */
  public int getVitesseMax() {
    return vitesseMax;
  }

  /**
   * Set la vitesse max de la voiture
   * @param vitesseMax La vitesse max de la voiture
   */
  public void setVitesseMax(int vitesseMax) {
    this.vitesseMax = vitesseMax;
  }

  /**
   * get le prix de la voiture
   * @return Le prix de la voiture
   */
  public int getPrix() {
    return prix;
  }

  /**
   * Set le prix de la voiture
   * @param prix Le prix de la voiture
   */
  public void setPrix(int prix) {
    this.prix = prix;
  }

  /**
   * Affiche le résumé du véhicule au format JSON
   */
  public void afficherVehiculeAB() {
    System.out.println("VoitureAB{" +
            "id=" + id +
            ", marque='" + marque + '\'' +
            ", modele='" + modele + '\'' +
            ", puissance=" + puissance +
            ", vitesseMax=" + vitesseMax +
            ", prix=" + prix +
            '}');
  }
}
