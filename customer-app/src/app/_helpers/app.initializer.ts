import { catchError, of } from 'rxjs';
import { AuthService } from '../shared/services';

export function appInitializer(authenticationService: AuthService) {
    return () => authenticationService.refreshToken()
        .pipe(
            // catch error to start app on success or failure
            catchError(() => of())
        );
}