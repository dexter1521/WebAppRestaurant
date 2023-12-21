namespace WebAppRestaurant
{
    public class WeatherForecast
    {
        public DateOnly Date { get; set; }

        public int TemperatureC { get; set; }

        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

        public string? Summary { get; set; }
    }
    public class PRodsResponse
    {
        public string Articulo { get; set; } = null!;

        public string? Descrip { get; set; }

        public string? Linea { get; set; }


        public double Precio1 { get; set; }
    }
}
