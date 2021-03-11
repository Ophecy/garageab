package com.garageab;

/**
 * @author arthur
 * @version 1.0
 *
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
   * Permet de renvoyer <i>l'ID</i> d'une voiture
   * @return L'ID de la voiture sous forme d'entier
   */
  public int getId() {
    return id;
  }

  /**
   * Permet de définir <b>l'ID</b> de la voiture
   * @param id
   * @deprecated Preferer la méthode newSetId
   */
  public void setId(int id) {
    this.id = id;
  }
  /**
   * Permet de définir <b>l'ID</b> de la voiture
   * @param id
   * @since 1.0
   */
  public void newSetId(int id) {
    this.id = id;
  }

  /**
   * Renvoie la marque de la voiture
   * @return
   */
  public String getMarque() {
    return marque;
  }

  /**
   * Définit la marque de la voiture
   * @param marque
   */
  public void setMarque(String marque) {
    this.marque = marque;
  }

  public String getModele() {
    return modele;
  }

  public void setModele(String modele) {
    this.modele = modele;
  }

  public int getPuissance() {
    return puissance;
  }

  public void setPuissance(int puissance) {
    this.puissance = puissance;
  }

  public int getVitesseMax() {
    return vitesseMax;
  }

  public void setVitesseMax(int vitesseMax) {
    this.vitesseMax = vitesseMax;
  }

  public int getPrix() {
    return prix;
  }

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
