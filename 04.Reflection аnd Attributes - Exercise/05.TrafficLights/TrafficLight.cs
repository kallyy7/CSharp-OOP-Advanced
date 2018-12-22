using System;

public class TrafficLight
{
    private Signal currentSignal;

    public TrafficLight(string signal)
    {
        this.currentSignal = (Signal)Enum.Parse(typeof(Signal), signal);
    }

    public void Update()
    {
        int previous = (int)currentSignal;
        previous++;
        currentSignal = (Signal)(previous % Enum.GetNames(typeof(Signal)).Length);
    }
}

