export const projectManagerNavigation = [
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
          icon: 'repeat',
        }
      ],
    },
    {
      text: 'GA',
      badge: 12,
      icon: 'pinleft',
      items: [
        {
          text: 'GA and Specs',
          path: '/ga-spec',
          icon: 'columnchooser',
        },
        {
          text: 'GA and Specs History',
          path: '/ga-spec-history',
          icon: 'range',
        }
      ],
    },
    
  ];
  