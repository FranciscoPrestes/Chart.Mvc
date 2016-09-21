namespace Chart.Mvc.ComplexChart
{
    /// <summary>
    /// The doughnut chart.
    /// </summary>
    public class DoughnutChart : ComplexChartBase<DoughnutChartOptions>
    {
        private readonly DoughnutChartOptions chartOptions = new DoughnutChartOptions();
        /// <summary>
        /// Gets the chart type.
        /// </summary>
        public override ComplexChartType ChartType
        {
            get
            {
                return ComplexChartType.Doughnut;
            }
        }

        /// <summary>
        /// Gets the chart configuration.
        /// </summary>
        public override DoughnutChartOptions ChartConfiguration
        {
            get
            {
                return chartOptions;
            }
        }
    }
}
