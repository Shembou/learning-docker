import { ShowType } from "../enums/ShowType";


export interface IShow {
    showId: number;
    title: string;
    year: string;
    rated?: string;
    runtime?: string;
    genre?: string;
    director?: string;
    actors?: string;
    plot?: string;
    language?: string;
    country?: string;
    awards?: string;
    poster: string;
    metascore: number;
    imdbRating: number;
    imdbVotes: number;
    type: ShowType;
    images: Array<string>;
}