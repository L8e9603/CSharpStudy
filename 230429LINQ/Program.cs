using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Order> orders = getOrders();

            Order petersFirstOrder = orders.Where(o => o.UserID == "Peter").FirstOrDefault(); // Where() 함수를 이용해 Peter가 넣은 첫번째 주문 찾기

            Console.WriteLine($"Peter's first order ID: {petersFirstOrder.ID}");

            petersFirstOrder = orders.FirstOrDefault(o => o.UserID == "Peter"); // FirstOrDefault() 함수를 이용해 Peter가 넣은 첫번째 주문 찾기

            Console.WriteLine($"Peter's first order ID: {petersFirstOrder.ID}");

            List<Order> petersOrders = orders.Where(o => o.UserID == "Peter").ToList(); // Peter의 모든 주문 가져오고, 가져온 데이터셋을 리스트로 변환

            if (petersOrders.Any()) // Peter가 주문을 넣은 적이 있는지 확인, Any() 함수는 파라미터 없이 호출할 때, 개체가 하나라도 있으면 true 반환
            {
                Console.WriteLine($"Peter has {petersOrders.Count} orders!");
            }

            /// Peter가 주문한 제품 전부 가져오기
            /// SelectMany() 함수를 사용하면 Order개체의 OrderItems 리스트 안에 있는 OrderItem 개체들이 petersOrderItems 리스트 안에 모두 담겨 반환됨
            /// Select() 함수를 사용하면 petersOrderItems 리스트 안에 OrderItems 리스트들이 반환됨
            /// 
            /// 자세한 예시)
            /// 주문1: 제품1(이름: 칫솔, 가격: 1000, 수량: 4), 제품2, 제품3
            /// 주문2: 제품4, 제품5
            /// SelectMany() -> petersOrderItems: 제품1, 제품2, 제품3, 제품4, 제품5
            /// Select() -> petersOrderItems: 주문1, 주문2
            List<OrderItem> petersOrderItems = petersOrders.SelectMany(o => o.OrderItems).ToList(); // 이제부터 모든 제품 개체가 담긴 petersOrderItems 리스트 개체를 여러곳에서 가지고 놀아보자

            printOrderItems(petersOrderItems); // Peter의 주문들에 존재하는 모든 주문 제품들 출력

            List<OrderItem> petersOrderItemsOrderedByIdDesc = petersOrderItems.OrderByDescending(o => o.ID).ToList(); // 가져온 주문 제품 리스트를 ID 내림차순으로 정렬

            printOrderItems(petersOrderItemsOrderedByIdDesc);

            List<OrderItem> orderedByPrice = petersOrderItems.OrderByDescending(o => o.Price).ToList(); // 가격에 따라 정렬 (오름차순)

            printOrderItems(orderedByPrice); // 가장 싼 OrderItem부터 비싼 순서로 출력된다

            List<string> productList = petersOrderItems.Select(oi => oi.Name).ToList(); // 가져온 주문 제품 리스트에서 Name 멤버(칼럼)만 뽑아 리스트로 만들기

            Console.WriteLine($"Peter bought: {string.Join(", ", productList)}");


            List<OrderItem> allOrderItems = orders.SelectMany(o => o.OrderItems).ToList(); // 모든 고객의 주문의 모든 제품을 가져옴

            decimal totalPrice = allOrderItems.Sum(oi => oi.Price * oi.Quantity); // Sum() 함수를 이용해 모든 제품의 총 가격 구하기

            Console.WriteLine($"Total Price of all order items: {totalPrice}");
        }

        /// <summary>
        /// DB에서 데이터를 가져오는 메서드 (가정)
        /// </summary>
        /// <returns>List</returns>
        private static List<Order> getOrders()
        {
            OrderItem tempOrderItem = new OrderItem() // 임시 제품
            {
                ID = 1,
                Name = "Cup",
                Price = 10000,
                Quantity = 1
            };

            OrderItem tempOrderItem2 = new OrderItem() // 임시 제품
            {
                ID = 2,
                Name = "Juice",
                Price = 2000,
                Quantity = 1
            };

            OrderItem tempOrderItem3 = new OrderItem() // 임시 제품
            {
                ID = 3,
                Name = "Chocolate",
                Price = 100,
                Quantity = 1
            };

            List<OrderItem> tempOrderItems = new List<OrderItem>() { tempOrderItem, tempOrderItem2, tempOrderItem3 }; // 장바구니 목록에 임시 제품 넣기

            Order tempOrder = new Order() // 임시 주문 생성
            {
                ID = 1,
                UserID = "Peter",
                OrderItems = tempOrderItems
            };

            return new List<Order>() { tempOrder };
        }

        private static void printOrderItems(List<OrderItem> orderItem)
        {
            foreach (OrderItem item in orderItem)
            {
                Console.WriteLine(item.Name);
            }
        }
    }
}