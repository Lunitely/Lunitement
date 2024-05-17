namespace LunitelyOS_Desktop_Environment.Contracts.Services;

public interface IActivationService
{
    Task ActivateAsync(object activationArgs);
}
