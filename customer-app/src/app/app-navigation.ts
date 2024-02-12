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
        text: 'Users',
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
    icon: 'assets/img/account.svg',
    items: [
      {
        text: 'Statement',
        path: '/customer-statement',
        icon: 'assets/img/statement.svg',
      }
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
