namespace SEP_Phone
{
    internal class CoordConversion
    {
        private Coordonnee vecteur;

        public CoordConversion()
        {
            this.vecteur = new Coordonnee();
        }

        public CoordConversion(Coordonnee cgps)
        {
            this.vecteur = new Coordonnee(cgps);
        }

        public CoordConversion(Coordonnee cgps, Coordonnee cgps_changed)
        {
            this.vecteur = new Coordonnee(cgps_changed);
            this.vecteur.decX(cgps.getX());
            this.vecteur.decY(cgps.getX());
            this.vecteur.decZ(cgps.getX());
        }

    }
}