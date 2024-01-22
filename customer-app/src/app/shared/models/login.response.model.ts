import { Customer } from "./customer.model"

export interface AuthResponse {
  succeeded: boolean
  message: string
  errors: any
  result: Result
}

export interface Result {
  id: string
  email: string
  jwToken: string
  memberType: string
  customer: Customer
}