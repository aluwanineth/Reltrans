export const accountantNavigation = [
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
        }
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
  