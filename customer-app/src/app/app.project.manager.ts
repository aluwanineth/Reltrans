export const projectManagerNavigation = [
    {
      text: 'Home',
      path: '/home',
      icon: 'home'
    },
    {
      text: 'Orders',
      icon: 'cart',
      items: [
        {
          text: 'Open Orders',
          path: '/open-orders',
          icon: 'assets/img/quaterlyData.svg',
        },
        {
          text: 'Order History',
          path: '/customer-order-history',
          icon: 'assets/img/JIT.svg'
        },
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
  