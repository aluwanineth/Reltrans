import { catchError, of } from 'rxjs';
import { AuthenticationService } from '../shared/services/account.service';

export function appInitializer(authenticationService: AuthenticationService) {
    return () => authenticationService.refreshToken()
        .pipe(
            // catch error to start app on success or failure
            catchError(() => of())
        );
}