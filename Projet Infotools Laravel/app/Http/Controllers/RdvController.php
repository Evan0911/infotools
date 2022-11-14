<?php

namespace App\Http\Controllers;

use Illuminate\Http\Request;
use App\Models\Client;
use App\Models\Prospect;
use App\Models\Rdv;

class RdvController extends Controller
{

    public function __construct()
    {
        $this->middleware('auth');
    }

    /**
     * Display a listing of the resource.
     *
     * @return \Illuminate\Http\Response
     */
    public function index()
    {
        //
    }

    /**
     * Show the form for creating a new resource.
     *
     * @return \Illuminate\Http\Response
     */
    public function create()
    {
        $clients = Client::first()->get();
        $pros = Prospect::first()->get();
        return view('rdvs.create', compact('clients','pros'));
    }

    /**
     * Store a newly created resource in storage.
     *
     * @param  \Illuminate\Http\Request  $request
     * @return \Illuminate\Http\Response
     */
    public function store(Request $request)
    {
        $rdv = new Rdv;

        $rdv->dateRdv = $request->input('dateRdv') . ' ' . $request->input('time').':00';
        $rdv->idCli = $request->input('idCli');
        $rdv->idPro = $request->input('idPro');
        $rdv->save();
        return redirect()->route('clients.index')
                        ->with('success','RDV created successfully');
    }

    /**
     * Display the specified resource.
     *
     * @param  int  $id
     * @return \Illuminate\Http\Response
     */
    public function show($id)
    {
        //
    }

    /**
     * Show the form for editing the specified resource.
     *
     * @param  int  $id
     * @return \Illuminate\Http\Response
     */
    public function edit($id)
    {
        $clients = Client::first()->get();
        $pros = Prospect::first()->get();
        $rdv = Rdv::find($id);
        return view('rdvs.edit', compact('clients','pros', 'rdv'));
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
        $rdv = Rdv::find($id);

        $rdv->dateRdv = $request->input('dateRdv') . ' ' . $request->input('time').':00';
        $rdv->idCli = $request->input('idCli');
        $rdv->idPro = $request->input('idPro');
        $rdv->save();
        return redirect()->route('clients.index')
                        ->with('success','RDV created successfully');
    }

    /**
     * Remove the specified resource from storage.
     *
     * @param  int  $id
     * @return \Illuminate\Http\Response
     */
    public function destroy($id)
    {
        Rdv::find($id)->delete();
        return redirect()->route('clients.index')
                        ->with('success','RDV deleted successfully');
    }
}
