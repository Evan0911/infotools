<?php

namespace App\Http\Controllers;

use App\Http\Controllers\Controller;
use Illuminate\Http\Request;
use App\Models\Client;
use App\Models\Rdv;
use App\Models\Commande;

class ClientController extends Controller
{
    /**
     * Display a listing of the resource.
     * on appelle les clients dans la base de données et créer des pages de 5 clients
     * on retourne la vue clients.index avec comme paramètre la réponse de la BDD
     * @return \Illuminate\Http\Response
     */

    public function __construct()
    {
        $this->middleware('auth');
    }

    public function index()
    {
        $rdvs = Rdv::first()->paginate(5);
        $clients = Client::first()->paginate(5);
        return view('clients.index',compact('clients', 'rdvs'))
            ->with('i', (request()->input('page', 1) - 1) * 5);
    }

    /**
     * Show the form for creating a new resource.
     *
     * @return \Illuminate\Http\Response
     */
    public function create()
    {
        return view('clients.create');
    }

    /**
     * Store a newly created resource in storage.
     *
     * @param  \Illuminate\Http\Request  $request
     * @return \Illuminate\Http\Response
     */
    public function store(Request $request)
    {
        request()->validate([
            'prenomCli' => 'required|max:255',
            'nomCli' => 'required|max:255',
            'adresseCli' => 'required|max:255',
            'cpCli' => 'required|max:255',
            'villeCli' => 'required|max:255',
            'telCli' => 'required|max:255',
            'mailCli' => 'required|email|max:255',
        ]);

        Client::create($request->all());
        return redirect()->route('clients.index')
                        ->with('success','Client created successfully');
    }

    /**
     * Display the specified resource.
     *
     * @param  int  $id
     * @return \Illuminate\Http\Response
     */
    public function show($id)
    {
        $commandes = Commande::where('idCli',$id)->get();
        $client = Client::find($id);
        return view('clients.show',compact('client', 'commandes'));
    }

    /**
     * Show the form for editing the specified resource.
     *
     * @param  int  $id
     * @return \Illuminate\Http\Response
     */
    public function edit($idCli)
    {
        $client = Client::find($idCli);
        return view('clients.edit',compact('client'));
    }

    /**
     * Update the specified resource in storage.
     *
     * @param  \Illuminate\Http\Request  $request
     * @param  int  $id
     * @return \Illuminate\Http\Response
     */
    public function update(Request $request, $id)
    {
        request()->validate([
            'prenomCli' => 'required',
            'nomCli' => 'required',
            'adresseCli' => 'required',
            'cpCli' => 'required',
            'villeCli' => 'required',
            'telCli' => 'required',
            'mailCli' => 'required',
        ]);
        Client::find($id)->update($request->all());
        return redirect()->route('clients.index')
                        ->with('success','Client updated successfully');
    }

    /**
     * Remove the specified resource from storage.
     *
     * @param  int  $id
     * @return \Illuminate\Http\Response
     */
    public function destroy($id)
    {
        Client::find($id)->delete();
        return redirect()->route('clients.index')
                        ->with('success','Client deleted successfully');
    }
}
