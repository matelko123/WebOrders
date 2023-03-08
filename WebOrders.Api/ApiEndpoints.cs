namespace WebOrders.Api;

public static class ApiEndpoints
{
    private const string ApiBase = "api";

    public static class Orders
    {
        private const string Base = $"{ApiBase}/orders";

        public const string GetAll = Base;
    }
}