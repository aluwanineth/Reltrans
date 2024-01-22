export const buyerNavigation = [
    {
      text: 'Home',
      path: '/home',
      icon: 'home'
    },
    {
      text: 'Orders',
      badge: 12,
      icon: 'cart',
      items: [
        {
          text: 'Customer Oders',
          path: '/customer-orders',
          icon: 'ordersbox',
        },
        {
          text: 'Order History',
          path: '/order-history',
          icon: 'ordersbox',
        }
      ],
    },
  ];
  