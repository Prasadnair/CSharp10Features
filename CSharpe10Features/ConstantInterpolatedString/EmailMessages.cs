namespace ConstantInterpolatedString
{
    public static class EmailMessages
    {
        private const string Salutation = "Welcome";

        public static class Header
        {
            public const string SalutionTeamplate = $"{Salutation} to Interpolation";
        }
    }
}
