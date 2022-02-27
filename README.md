#### RestApi Case
CustomerId, ShoppingType ve TotalAmount parametleri gönderilerek toplam tutar üzerinden indirim uygulayıp, net tutarı dönderen uygulama.

Proje toplam 4 katmandan oluşmaktadır.

- APIRest
- APIRest.Application
- APIRest.Application.Constant
- APIRest.Domain

Projeye ait UML Diagram => https://raw.githubusercontent.com/burakmt/RestApi/main/APIRest.png

Repository indirildikten sonra VS IDE üzerinden APIRest.sln açılıp herhangi bir ayar yapılmadan direkt olarak başlatılabilir.

------------

#### API URL
                    
                    
URL  | METHOD | Params | Return
------------- | ------------- | ------------- | --------------
/api/test/{id}  | GET | CustomerID (int) |BaseResponseModel
/api/get-invoice  | POST  | RequestModel |BaseResponseModel

###### Customers
**/api/test/{id}** url "ID" parametresi için örnek kullanıcılar;
```csharp
customers.Add(new Customers(1, "NameOne","SurnameOne",CustomerType.Employee,DateTime.Now));
customers.Add(new Customers(2, "NameTwo", "SurnameTwo", CustomerType.Normal, DateTime.Now));
customers.Add(new Customers(3, "NameThree", "SurnameThree", CustomerType.Public, DateTime.Now.AddYears(2)));
```

**/api/get-invoice** url "POST" edilmesi gereken model;
```csharp
{
    "totalAmount": "decimal",
    "shoppingType": "int", // 1 => Product; 2 => Market
    "customerId": "int"
}
```
###### Response Model
```csharp
{
    "success": "bool",
    "data": "object",
    "date": "datetime"
}
```
