export const buyerNavigation = [
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
  ];
  