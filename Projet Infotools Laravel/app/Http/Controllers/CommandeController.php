<?php

namespace App\Http\Controllers;

use Illuminate\Http\Request;
use App\Models\Commande;

class CommandeController extends Controller
{

    public function __construct()
    {
        $this->middleware('auth');
    }

    public function index()
    {
        $commandes = Commande::latest()->paginate(5);
        return view('commandes.index',compact('commandes'))
            ->with('i', (request()->input('page', 1) - 1) * 5);
    }

    public function show($id)
    {
        $commande = Commande::find($id);
        return view('commandes.show',compact('commande'));
    }
}
