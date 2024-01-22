export const adminNavigation = [
  {
    text: 'Home',
    path: '/home',
    icon: 'home'
  },
  {
    text: 'Administrator',
    badge: 12,
    icon: 'preferences',
    items: [
      {
        text: 'Customer Managment',
        path: '/user-data',
        icon: 'user',
      },
    ],
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
  {
    text: 'Accounts',
    badge: 12,
    icon: 'ordersbox',
    items: [
      {
        text: 'Account Statements',
        path: '/account-statement',
        icon: 'sortdowntext',
      },
      {
        text: 'Invoices',
        path: '/invoice',
        icon: 'exportpdf',
      },
      {
        text: 'Transaction History',
        path: '/transaction-history',
        icon: '',
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
