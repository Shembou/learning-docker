import { Injectable } from '@angular/core';
import { Router } from '@angular/router';
import { HttpClient, HttpErrorResponse } from '@angular/common/http';
import { Observable, throwError } from 'rxjs';
import { catchError } from 'rxjs/operators';

/**
 * @class ApiService
 * @description A service for handling API requests throughout the application.
 * 
 * Provides a method for handling `GET` requests dynamically. The endpoint
 * is constructed either based on the provided route or the current URL route.
 * 
 * The service includes error handling for API requests.
 */

@Injectable({
  providedIn: 'root'
})

export class ApiService {

    /**
   * Constructor for the ApiService
   * 
   * @param {Router} router - Angular Router to determine the current route.
   * @param {HttpClient} httpClient - Angular HttpClient to handle HTTP requests.
   */

  constructor(
    private router: Router,
    private httpClient: HttpClient
  ) {}

  /**
   * Sends a GET request to the specified route or the current route.
   * 
   * @param route Optional. The route for the API request. If not provided, the current route will be used.
   * @returns Observable<T> - The result of the GET request as an observable of type `T`.
   * 
   * @template T The expected response type for the GET request.
   */
  get<T>(route?: string): Observable<T> {
    const endpoint = this.setEndpoint(route);
    return this.httpClient.get<T>(endpoint).pipe(
      catchError(this.handleError) // Error handling
    );
  }

  /**
   * Constructs the full API endpoint based on the given route or the current route.
   * 
   * @param route Optional. The specific API route. If not provided, the current URL is used.
   * @returns string - The full API endpoint URL.
   */
  private setEndpoint(route?: string): string {
    return route ? `/api/${route}` : `/api${this.router.url}`;
  }

  /**
   * Error handling method for HTTP requests.
   * 
   * @param error The HTTP error response.
   * @returns Observable<never> - An observable that throws an error with a user-friendly message.
   */
  private handleError(error: HttpErrorResponse): Observable<never> {
    let errorMessage = '';

    if (error.error instanceof ErrorEvent) {
      errorMessage = `Client-side error: ${error.error.message}`;
    } else {
      errorMessage = `Server returned code ${error.status}, body was: ${error.message}`;
    }

    console.error(errorMessage); // Log the error to the console
    return throwError(() => new Error('An error occurred while processing your request.'));
  }

}