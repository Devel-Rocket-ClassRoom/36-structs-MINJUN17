using System;

int totalPrice = 0;
double totalWeight = 0;
int averagePrice = 0;
int maxPrice = int.MinValue;
string maxPriceItem = string.Empty;
double minWeight = double.MaxValue;
string minWeightItem = string.Empty;
InventoryItem[] items = new InventoryItem[5];
items[0] = new InventoryItem("검", 3.5, 1500);
items[1] = new InventoryItem("방패", 5, 1200);
items[2] = new InventoryItem("포션", 0.3, 50);
items[3] = new InventoryItem("활", 1.8, 1300);
items[4] = new InventoryItem("투구", 2, 800);
Console.WriteLine("=== 인벤토리 목록 ===");
for(int i = 0; i < items.Length; i++)
{
    Console.WriteLine($"{items[i].Name} - 무게: {items[i].Weight}Kg, 가격: {items[i].Price}골드");
    totalPrice += items[i].Price;
    totalWeight += items[i].Weight;
    if (items[i].Price > maxPrice)
    {
        maxPrice = items[i].Price;
        maxPriceItem = items[i].Name;
    }
    if (items[i].Weight < minWeight)
    {
        minWeight = items[i].Weight;
        minWeightItem = items[i].Name;
    }
}
averagePrice = totalPrice / items.Length;
Console.WriteLine();
Console.WriteLine("=== 인벤토리 통계");
Console.WriteLine($"전체 무게: {totalWeight:f1}Kg");
Console.WriteLine($"전체 가격: {totalPrice}골드");
Console.WriteLine($"평균 가격: {averagePrice}골드");
Console.WriteLine($"가장 비싼 아이템: {maxPriceItem}");
Console.WriteLine($"가장 가벼운 아이템: {minWeightItem}");


