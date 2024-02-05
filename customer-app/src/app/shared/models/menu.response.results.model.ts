export interface MenuResponseResults {
    succeeded: boolean
    message: any
    errors: any
    result: Result[]
  }
  
  export interface Result {
    text: string
    path: string
    icon: string
    items: Item[]
  }
  
  export interface Item {
    text: string
    path: string
    icon: string
  }