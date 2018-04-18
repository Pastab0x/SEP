namespace SEP_Phone
{
    internal class CoordConversion
    {
        Coordonnee vecteur;

        public CoordConversion(Coordonnee cgps, Coordonnee cgps_changed)
        {
            this.vecteur.getX() = cgps_changed.x - cgps.x;
        }

    }
}