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
      icon: 'pinleft',
      items: [
        {
          text: 'GA and Specs',
          path: '/customer-ga',
          icon: 'columnchooser',
        },
        {
          text: 'Specs History',
          path: '/customer-ga-history',
          icon: 'range',
        }
      ],
    },
    
  ];
  