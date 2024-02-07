export const adminNavigation = [
  {
    text: 'Home',
    path: '/home',
    icon: 'assets/img/icons8-home.svg'
  },
  {
    text: 'Administrator',
    icon: 'assets/img/icons8-settings.svg',
    path:'',
    items: [
      {
        text: 'Customers',
        path: '/user-data',
        icon: 'assets/img/icons8-myspace.svg',
      }
    ]
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
    text: 'Accounts',
    icon: 'cart',
    items: [
      {
        text: 'Statement',
        path: '/customer-statement',
        icon: 'assets/img/quaterlyData.svg',
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
