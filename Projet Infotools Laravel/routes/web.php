<?php

use Illuminate\Support\Facades\Route;
use App\Http\Controllers\ClientController;
use App\Http\Controllers\CommandeController;
use App\Http\Controllers\HomeController;
use App\Http\Controllers\ProduitController;
use App\Http\Controllers\RdvController;
/*
|--------------------------------------------------------------------------
| Web Routes
|--------------------------------------------------------------------------
|
| Here is where you can register web routes for your application. These
| routes are loaded by the RouteServiceProvider within a group which
| contains the "web" middleware group. Now create something great!
|
*/

Route::resource('clients','App\Http\Controllers\ClientController');
Route::resource('/','App\Http\Controllers\ClientController');
Route::resource('produits','App\Http\Controllers\ProduitController');
Route::resource('commandes','App\Http\Controllers\CommandeController');
Route::resource('rdvs','App\Http\Controllers\RdvController');
Auth::routes();

Route::get('/home', 'App\Http\Controllers\HomeController@index')->name('home');

