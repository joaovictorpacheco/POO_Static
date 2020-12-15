namespace POOStatic.classes
{
    public static class Conversor
    {
        private static  float CotacaoEuro = 6.22f;

        public static float RealParaEuro(float valorRS){
            return valorRS / CotacaoEuro;
        }

        public static float EuroParaReais(float valorRS){
            return CotacaoEuro * valorRS;
        }
    }
}