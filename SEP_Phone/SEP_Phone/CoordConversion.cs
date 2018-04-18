namespace SEP_Phone
{
    internal class CoordConversion
    {
        private Coordonnee vecteur;

        public CoordConversion(Coordonnee cgps, Coordonnee cgps_changed)
        {
            this.vecteur.setX(cgps_changed.getX() - cgps.getX());
        }

    }
}