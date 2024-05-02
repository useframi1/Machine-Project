using System;
using System.Collections.Generic;

namespace API.Entities;

public partial class UserPrediction
{
    public string Username { get; set; }

    public int DayOfWeek { get; set; }

    public DateOnly Date { get; set; }

    public int ScheduledArrTime { get; set; }

    public string AirlineName { get; set; }

    public string TailNum { get; set; }

    public string OrgAirport { get; set; }

    public string DestAirport { get; set; }

    public int Distance { get; set; }

    public int ScheduledDepTime { get; set; }

    public int ScheduledElapsedTime { get; set; }

    public double DepTemperature { get; set; }

    public double DepWindSpeed { get; set; }

    public double DepWindDirection { get; set; }

    public double DepPrecipitation { get; set; }

    public double DepRain { get; set; }

    public double DepSnowFall { get; set; }

    public double ArrTemperature { get; set; }

    public double ArrWindSpeed { get; set; }

    public double ArrWindDirection { get; set; }

    public double ArrPrecipitation { get; set; }

    public double ArrRain { get; set; }

    public double ArrSnowFall { get; set; }

    public bool IsDelayedPredicted { get; set; }

    public bool? IsDelayedActual { get; set; }

    public virtual Airline AirlineNameNavigation { get; set; }

    public virtual Airport DestAirportNavigation { get; set; }

    public virtual Airport OrgAirportNavigation { get; set; }

    public virtual TailNumber TailNumNavigation { get; set; }

    public virtual User UsernameNavigation { get; set; }
}
