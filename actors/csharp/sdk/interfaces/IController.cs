using Dapr.Actors;

namespace SmartDevice.Interfaces;
public interface IController : IActor
{
    Task<decimal> GetNetBatteryPercentage();
    Task<decimal> GetAverageTemperature();
    Task RegisterSmokeDetectorsAsync(ControllerData data);
    Task TriggerAlarmForAllDetectors();
}

public class ControllerData
{
    public string[] DeviceIds { get; set; } = default!;
}