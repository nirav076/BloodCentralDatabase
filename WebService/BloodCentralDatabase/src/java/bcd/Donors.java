/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

package bcd;

import java.io.Serializable;
import javax.persistence.Basic;
import javax.persistence.Column;
import javax.persistence.Entity;
import javax.persistence.Id;
import javax.persistence.JoinColumn;
import javax.persistence.ManyToOne;
import javax.persistence.NamedQueries;
import javax.persistence.NamedQuery;
import javax.persistence.Table;
import javax.validation.constraints.NotNull;
import javax.validation.constraints.Size;
import javax.xml.bind.annotation.XmlRootElement;

/**
 *
 * @author Sohil
 */
@Entity
@Table(name = "donors")
@XmlRootElement
@NamedQueries({
    @NamedQuery(name = "Donors.findAll", query = "SELECT d FROM Donors d"),
    @NamedQuery(name = "Donors.findById", query = "SELECT d FROM Donors d WHERE d.id = :id"),
    @NamedQuery(name = "Donors.findByName", query = "SELECT d FROM Donors d WHERE d.name = :name"),
    @NamedQuery(name = "Donors.findByBloodgroup", query = "SELECT d FROM Donors d WHERE d.bloodgroup = :bloodgroup"),
    @NamedQuery(name = "Donors.findByContact", query = "SELECT d FROM Donors d WHERE d.contact = :contact"),
    @NamedQuery(name = "Donors.findByAddress", query = "SELECT d FROM Donors d WHERE d.address = :address"),
    @NamedQuery(name = "Donors.findByResidentialArea", query = "SELECT d FROM Donors d WHERE d.residentialArea = :residentialArea"),
    @NamedQuery(name = "Donors.findByCity", query = "SELECT d FROM Donors d WHERE d.city = :city"),
    @NamedQuery(name = "Donors.findByState", query = "SELECT d FROM Donors d WHERE d.state = :state"),
    @NamedQuery(name = "Donors.findByAvailability", query = "SELECT d FROM Donors d WHERE d.availability = :availability"),
    @NamedQuery(name = "Donors.findByLastDonated", query = "SELECT d FROM Donors d WHERE d.lastDonated = :lastDonated")})
public class Donors implements Serializable {
    private static final long serialVersionUID = 1L;
    @Id
    @Basic(optional = false)
    @NotNull
    @Size(min = 1, max = 6)
    @Column(name = "id")
    private String id;
    @Basic(optional = false)
    @NotNull
    @Size(min = 1, max = 50)
    @Column(name = "name")
    private String name;
    @Basic(optional = false)
    @NotNull
    @Size(min = 1, max = 10)
    @Column(name = "bloodgroup")
    private String bloodgroup;
    @Basic(optional = false)
    @NotNull
    @Size(min = 1, max = 20)
    @Column(name = "contact")
    private String contact;
    @Basic(optional = false)
    @NotNull
    @Size(min = 1, max = 60)
    @Column(name = "address")
    private String address;
    @Basic(optional = false)
    @NotNull
    @Size(min = 1, max = 30)
    @Column(name = "residentialArea")
    private String residentialArea;
    @Basic(optional = false)
    @NotNull
    @Size(min = 1, max = 30)
    @Column(name = "city")
    private String city;
    @Basic(optional = false)
    @NotNull
    @Size(min = 1, max = 30)
    @Column(name = "state")
    private String state;
    @Basic(optional = false)
    @NotNull
    @Size(min = 1, max = 15)
    @Column(name = "availability")
    private String availability;
    @Basic(optional = false)
    @NotNull
    @Size(min = 1, max = 15)
    @Column(name = "lastDonated")
    private String lastDonated;
    @JoinColumn(name = "associatedWith", referencedColumnName = "id")
    @ManyToOne(optional = false)
    private Bloodbanks associatedWith;

    public Donors() {
    }

    public Donors(String id) {
        this.id = id;
    }

    public Donors(String id, String name, String bloodgroup, String contact, String address, String residentialArea, String city, String state, String availability, String lastDonated) {
        this.id = id;
        this.name = name;
        this.bloodgroup = bloodgroup;
        this.contact = contact;
        this.address = address;
        this.residentialArea = residentialArea;
        this.city = city;
        this.state = state;
        this.availability = availability;
        this.lastDonated = lastDonated;
    }

    public String getId() {
        return id;
    }

    public void setId(String id) {
        this.id = id;
    }

    public String getName() {
        return name;
    }

    public void setName(String name) {
        this.name = name;
    }

    public String getBloodgroup() {
        return bloodgroup;
    }

    public void setBloodgroup(String bloodgroup) {
        this.bloodgroup = bloodgroup;
    }

    public String getContact() {
        return contact;
    }

    public void setContact(String contact) {
        this.contact = contact;
    }

    public String getAddress() {
        return address;
    }

    public void setAddress(String address) {
        this.address = address;
    }

    public String getResidentialArea() {
        return residentialArea;
    }

    public void setResidentialArea(String residentialArea) {
        this.residentialArea = residentialArea;
    }

    public String getCity() {
        return city;
    }

    public void setCity(String city) {
        this.city = city;
    }

    public String getState() {
        return state;
    }

    public void setState(String state) {
        this.state = state;
    }

    public String getAvailability() {
        return availability;
    }

    public void setAvailability(String availability) {
        this.availability = availability;
    }

    public String getLastDonated() {
        return lastDonated;
    }

    public void setLastDonated(String lastDonated) {
        this.lastDonated = lastDonated;
    }

    public Bloodbanks getAssociatedWith() {
        return associatedWith;
    }

    public void setAssociatedWith(Bloodbanks associatedWith) {
        this.associatedWith = associatedWith;
    }

    @Override
    public int hashCode() {
        int hash = 0;
        hash += (id != null ? id.hashCode() : 0);
        return hash;
    }

    @Override
    public boolean equals(Object object) {
        // TODO: Warning - this method won't work in the case the id fields are not set
        if (!(object instanceof Donors)) {
            return false;
        }
        Donors other = (Donors) object;
        if ((this.id == null && other.id != null) || (this.id != null && !this.id.equals(other.id))) {
            return false;
        }
        return true;
    }

    @Override
    public String toString() {
        return "bcd.Donors[ id=" + id + " ]";
    }
    
}
